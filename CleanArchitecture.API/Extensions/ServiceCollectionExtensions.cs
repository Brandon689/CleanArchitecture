namespace CleanArchitecture.API.Extensions;

public static class ServiceCollectionExtensions
{
    public static void AddCorsPolicy(this IServiceCollection services, string policyName, BaseUrlConfiguration baseUrlConfig)
    {
        services.AddCors(options =>
        {
            options.AddPolicy(name: policyName,
                corsPolicyBuilder =>
                {
                    corsPolicyBuilder.WithOrigins(baseUrlConfig.WebBase);
                    corsPolicyBuilder.AllowAnyMethod();
                    corsPolicyBuilder.AllowAnyHeader();
                });
        });
    }
}
