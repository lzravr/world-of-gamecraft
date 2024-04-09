using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using WorldOfGamecraft.Common.Data;

namespace WorldOfGamecraft.CharacterService.Infrastructure;
public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
    {
        AddPersistence(services, configuration);

        return services;
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


        services.AddScoped<IUnitOfWork>(sp => sp.GetRequiredService<CharactersDbContext>());

    }
}
