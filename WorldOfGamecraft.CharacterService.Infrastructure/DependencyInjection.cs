using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using WorldOfGamecraft.CharacterService.Domain.CharacterClasses;
using WorldOfGamecraft.CharacterService.Domain.Characters;
using WorldOfGamecraft.CharacterService.Domain.Items;
using WorldOfGamecraft.CharacterService.Infrastructure.Repositories;
using WorldOfGamecraft.Common.Data;
using WorldOfGamecraft.Common.IdentityService;

namespace WorldOfGamecraft.CharacterService.Infrastructure;
public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
    {
        AddPersistence(services, configuration);
        AddAuthentication(services, configuration);

        services.AddScoped<IIdentityServiceClient, IdentityServiceClient>();

        return services;
    }

    private static void AddAuthentication(IServiceCollection services, IConfiguration configuration)
    {
        services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
            .AddJwtBearer(options =>
            {
                options.TokenValidationParameters = new()
                {
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.ASCII.GetBytes("436595f41407c630b7d4e16f0eabc89e261cf7ddcb6e1791c138c57737c6c8da")),
                    ValidateIssuerSigningKey = true,
                    ValidateAudience = false,
                    ValidateIssuer = false,
                    ValidateLifetime = true,
                    ClockSkew = TimeSpan.Zero
                };
            });
    }

    private static void AddPersistence(IServiceCollection services, IConfiguration configuration)
    {
        var connectionString =
                    configuration.GetConnectionString("Database") ??
                    throw new ArgumentNullException(nameof(configuration));

        services.AddDbContext<CharactersDbContext>(options =>
        {
            options.UseNpgsql(connectionString).UseSnakeCaseNamingConvention();
        });

        services.AddScoped<ICharacterRepository, CharacterRepository>();
        services.AddScoped<IClassRepository, ClassRepository>();
        services.AddScoped<IItemRepository, ItemRepository>();

        services.AddScoped<IUnitOfWork>(sp => sp.GetRequiredService<CharactersDbContext>());

    }
}
