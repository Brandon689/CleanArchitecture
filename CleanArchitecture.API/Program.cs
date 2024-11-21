using CleanArchitecture.API;
using CleanArchitecture.API.Endpoints.Coins;
using CleanArchitecture.API.Extensions;
using CleanArchitecture.Application;
using CleanArchitecture.Infrastructure;
using Microsoft.AspNetCore.Identity;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddOpenApi();

builder.Services
    .AddApiServices()
    .AddApplication()
    .AddInfrastructure(builder.Configuration);

var app = builder.Build();

//if (app.Environment.IsDevelopment())
//{
//    app.MapOpenApi();

//    app.UseSwagger();
//    app.UseSwaggerUI();
//}

//app.MapIdentityApi<IdentityUser>();
//app.UseHttpsRedirection();
//app.UseCors("AllowFrontend");

app.ConfigureMiddleware();

app.MapCoinEndpoints();

app.Run();