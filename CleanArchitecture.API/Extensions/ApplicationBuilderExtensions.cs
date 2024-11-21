using Microsoft.AspNetCore.Identity;

namespace CleanArchitecture.API.Extensions;

public static class ApplicationBuilderExtensions
{
    public static WebApplication ConfigureMiddleware(this WebApplication app)
    {
        if (app.Environment.IsDevelopment())
        {
            app.MapOpenApi();

            app.UseSwagger();
            app.UseSwaggerUI();
        }

        app.MapIdentityApi<IdentityUser>();
        app.UseHttpsRedirection();
        app.UseCors("AllowFrontend");

        return app;
    }
}