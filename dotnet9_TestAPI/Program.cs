using ACXBookingSystem.Entities;
using Anderson_Road.Entities;
using dotnet9_TestAPI.Services;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Scalar.AspNetCore;
using System.Security.AccessControl;
using System.Text;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<Anderson_RoadDbContext>(options =>
    options.UseSqlServer(
        builder.Configuration.GetConnectionString("DefaultConnection")
     ));
builder.Services.AddDbContext<ACXBookingSystemDbContext>(options =>
    options.UseSqlServer(
        builder.Configuration.GetConnectionString("ACXBookingSystemConnection")
     ));
builder.Services.AddDbContext<ACXBookingSystemDbContext>(options =>
    options.UseSqlServer(
        builder.Configuration.GetConnectionString("ACXBookingSystemConnection")
     ));

// Enable camelCase for JSON serialization (important!)
builder.Services.AddControllers()
    .AddJsonOptions(options =>
    {
        options.JsonSerializerOptions.PropertyNamingPolicy = System.Text.Json.JsonNamingPolicy.CamelCase;
        options.JsonSerializerOptions.DictionaryKeyPolicy = System.Text.Json.JsonNamingPolicy.CamelCase;
        options.JsonSerializerOptions.Converters.Add(new System.Text.Json.Serialization.JsonStringEnumConverter());
        // Add our custom DateTime converter
        options.JsonSerializerOptions.Converters.Add(new Anderson_Road.Models.CustomDateTimeConverter());
    });

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddScoped<BookingService>();

// 1. Register the OpenAPI document with a custom name ("v2")
builder.Services.AddOpenApi("v2", options =>
{
    // 2. Keep your existing transformer
    options.AddDocumentTransformer<BearerSecuritySchemeTransformer>();

    // You can add more transformers or configurations here
    options.AddDocumentTransformer((document, context, cancellationToken) =>
    {
        document.Info.Title = "My API v2";
        return Task.CompletedTask;
    });
});

//builder.Services.AddOpenApi(options =>
//{
//    options.AddDocumentTransformer<BearerSecuritySchemeTransformer>();
//});

// 1. Configure JWT Authentication
var jwtSettings = builder.Configuration.GetSection("Jwt");
var key = Encoding.ASCII.GetBytes(jwtSettings["Key"]!);

builder.Services.AddAuthentication(options =>
{
    options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
})
    .AddJwtBearer(options =>
    {
        options.TokenValidationParameters = new TokenValidationParameters
        {
            ValidateIssuer = false,
            ValidateAudience = false,
            ValidateLifetime = true,
            ValidateIssuerSigningKey = true,
            ValidIssuer = jwtSettings["Issuer"],
            ValidAudience = jwtSettings["Audience"],
            IssuerSigningKey = new SymmetricSecurityKey(key)
        };
    });

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment() || app.Environment.IsProduction())
{
    app.MapOpenApi(); // This generates /openapi/v2.json

    app.MapScalarApiReference(options =>
    {
        // 1. This sets the URL in your browser address bar
        options.WithEndpointPrefix("/scalar/v2");

        // 2. This tells Scalar exactly which JSON file to pull. 
        // By default, it looks for "/openapi/v1.json". 
        // We need to point it to the "v2" document you registered.
        options.WithOpenApiRoutePattern("/openapi/v2.json");
    });
}

//options.CustomCss = ".scalar-header { background-color: #2b2b2b; }";

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
