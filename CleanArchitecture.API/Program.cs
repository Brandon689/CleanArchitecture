using CleanArchitecture.API;
using CleanArchitecture.API.Endpoints.Coins;
using CleanArchitecture.API.Extensions;
using CleanArchitecture.Application;
using CleanArchitecture.Infrastructure;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddOpenApi();

builder.Services
    .AddApiServices()
    .AddApplication()
    .AddInfrastructure(builder.Configuration);

const string CORS_POLICY = "CorsPolicy";

var baseUrlConfig = builder.Configuration.GetSection("BaseUrls").Get<BaseUrlConfiguration>();

if (baseUrlConfig != null)
{
    builder.Services.AddCorsPolicy(CORS_POLICY, baseUrlConfig);
}

var app = builder.Build();

if (baseUrlConfig != null)
{
    app.UseCors(CORS_POLICY);
}

app.ConfigureMiddleware();
app.MapCoinEndpoints();

app.Run();

public partial class Program { }
