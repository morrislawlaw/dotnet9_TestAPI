using Anderson_Road.Entities;
using ACXBookingSystem.Entities;
using HotelBookingSystem.Entities;
using dotnet9_TestAPI.Services;
using Microsoft.AspNetCore.Authentication.JwtBearer;
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
builder.Services.AddOpenApi("v2", options =>
{
    options.AddDocumentTransformer<BearerSecuritySchemeTransformer>();
    options.AddDocumentTransformer((document, context, ct) =>
    {
        document.Info.Title = "Hotel Booking API v2";
        return Task.CompletedTask;
    });
});

// ===== JWT Authentication =====
var jwtSettings = builder.Configuration.GetSection("Jwt");
var key = Encoding.ASCII.GetBytes(jwtSettings["Key"]!);

builder.Services.AddAuthentication(options =>
{
    options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
})
// Google Authentication (NEW)
.AddGoogle(googleOptions =>
{
    googleOptions.ClientId = builder.Configuration["Authentication:Google:ClientId"]!;
    googleOptions.ClientSecret = builder.Configuration["Authentication:Google:ClientSecret"]!;
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

// ===== Middleware Pipeline (CRITICAL ORDER) =====
if (app.Environment.IsDevelopment() || app.Environment.IsProduction())
{
    app.MapOpenApi();
    app.MapScalarApiReference(options =>
    {
        options.WithEndpointPrefix("/scalar/v2");
        options.WithOpenApiRoutePattern("/openapi/v2.json");
    });
}

app.UseHttpsRedirection();

// CORS MUST be after UseRouting and before Authentication/Authorization
app.UseRouting();
app.UseCors("VueFrontendPolicy");

// ¡ö¡ö¡ö VERY IMPORTANT: These two lines must be in this order
app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();