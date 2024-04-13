using Microsoft.Extensions.DependencyInjection;
using WorldOfGamecraft.CharacterService.Application.Mapper;

namespace WorldOfGamecraft.CharacterService.Application;
public static class DependencyInjection
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        services.AddMediatR(configuration =>
        {
            configuration.RegisterServicesFromAssembly(typeof(DependencyInjection).Assembly);
        });

        services.AddAutoMapper(typeof(MapperProfile).Assembly);

        return services;
    }
}
