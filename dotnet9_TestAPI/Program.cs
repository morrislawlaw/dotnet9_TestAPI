using ACXBookingSystem.Entities;
using Anderson_Road.Entities;
using dotnet9_TestAPI.Services;
using HotelBookingSystem.Entities;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authentication.OAuth;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Scalar.AspNetCore;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);

// ===== Database Contexts =====
builder.Services.AddDbContext<Anderson_RoadDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddDbContext<ACXBookingSystemDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("ACXBookingSystemConnection")));

builder.Services.AddDbContext<HotelBookingSystemDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("HotelBookingSystemConnection")));

// ===== Services =====
builder.Services.AddScoped<BookingService>();
//builder.Services.AddHttpClient<EmailService>();
builder.Services.AddHttpClient<IEmailService, EmailService>();

// ===== CORS Policy (Production Ready) =====
builder.Services.AddCors(options =>
{
    options.AddPolicy("VueFrontendPolicy", policy =>
    {
        var allowedOrigins = builder.Configuration.GetSection("AllowedOrigins").Get<string[]>()
                           ?? new[] { "http://localhost:5173", "http://localhost:8080" };

        policy.WithOrigins(allowedOrigins)
              .AllowAnyHeader()
              .AllowAnyMethod()
              .AllowCredentials();   // Required if using cookies / JWT in HttpOnly cookie
    });
});

// ===== JSON Configuration =====
builder.Services.AddControllers()
    .AddJsonOptions(options =>
    {
        options.JsonSerializerOptions.PropertyNamingPolicy = JsonNamingPolicy.CamelCase;
        options.JsonSerializerOptions.DictionaryKeyPolicy = JsonNamingPolicy.CamelCase;
        options.JsonSerializerOptions.DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull;
        options.JsonSerializerOptions.NumberHandling = JsonNumberHandling.AllowReadingFromString;
        options.JsonSerializerOptions.Converters.Add(new JsonStringEnumConverter());
        options.JsonSerializerOptions.Converters.Add(new Anderson_Road.Models.CustomDateTimeConverter());
    });

// ===== OpenAPI / Scalar =====
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddOpenApi();
//builder.Services.AddOpenApi(options =>
//{
//    options.AddDocumentTransformer<BearerSecuritySchemeTransformer>();
//    options.AddDocumentTransformer((document, context, ct) =>
//    {
//        document.Info.Title = "Hotel Booking API v2";
//        return Task.CompletedTask;
//    });
//});

//builder.Services.AddOpenApi(options =>
//{
//    options.AddDocumentTransformer<BearerSecuritySchemeTransformer>();
//    options.AddDocumentTransformer((document, context, ct) =>
//    {
//        document.Info.Title = "Hotel Booking API v2";
//        return Task.CompletedTask;
//    });
//});

// ===== JWT Authentication =====
var jwtSettings = builder.Configuration.GetSection("Jwt");
var key = Encoding.ASCII.GetBytes(jwtSettings["Key"]!);

builder.Services.AddAuthentication(options =>
{
    options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;

    options.DefaultSignInScheme = CookieAuthenticationDefaults.AuthenticationScheme;
})
.AddCookie(options =>
{
    options.Cookie.SameSite = SameSiteMode.None; // Allows the cookie to survive cross-domain redirects
    options.Cookie.SecurePolicy = CookieSecurePolicy.Always; // Required when SameSite = None
})
// Google Authentication (NEW)
.AddGoogle(googleOptions =>
{
    googleOptions.ClientId = builder.Configuration["Authentication:Google:ClientId"]!;
    googleOptions.ClientSecret = builder.Configuration["Authentication:Google:ClientSecret"]!;

    // CRITICAL FIX: Force the middleware to use your exact callback path instead of /signin-google
    googleOptions.CallbackPath = "/api/auth/google-callback";

    // ADD THIS EVENT HOOK: Hand off control directly to your custom controller method!
    googleOptions.Events = new OAuthEvents
    {
        OnTicketReceived = context =>
        {
            // Bounces the user browser right into your token generation logic
            context.ReturnUri = "/api/auth/google-success";
            return Task.CompletedTask;
        }
    };

    // THE CRITICAL CORRELATION FIX:
    googleOptions.CorrelationCookie.SameSite = SameSiteMode.None;
    googleOptions.CorrelationCookie.SecurePolicy = CookieSecurePolicy.Always;
})
.AddJwtBearer(options =>
{
    options.TokenValidationParameters = new TokenValidationParameters
    {
        ValidateIssuer = true,
        ValidateAudience = true,
        ValidateLifetime = true,
        ValidateIssuerSigningKey = true,
        ValidIssuer = jwtSettings["Issuer"],
        ValidAudience = jwtSettings["Audience"],
        IssuerSigningKey = new SymmetricSecurityKey(key),
        ClockSkew = TimeSpan.Zero
    };
});

builder.Services.AddAuthorization();

var app = builder.Build();



app.UseHttpsRedirection();

// CORS MUST be after UseRouting and before Authentication/Authorization
app.UseRouting();
app.UseCors("VueFrontendPolicy");

// ←←← VERY IMPORTANT: These two lines must be in this order
app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

// ===== Middleware Pipeline (CRITICAL ORDER) =====
if (app.Environment.IsDevelopment() || app.Environment.IsProduction())
{
    //app.MapOpenApi();
    //app.MapScalarApiReference(options =>
    //{
    //    options.WithEndpointPrefix("/scalar/v2");
    //    options.WithOpenApiRoutePattern("/openapi/v2.json");
    //});


    app.MapOpenApi();
    app.MapScalarApiReference();
}
app.Run();