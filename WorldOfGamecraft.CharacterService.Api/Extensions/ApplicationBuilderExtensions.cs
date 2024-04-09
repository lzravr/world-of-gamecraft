using Microsoft.EntityFrameworkCore;
using WorldOfGamecraft.CharacterService.Infrastructure;

namespace WorldOfGamecraft.CharacterService.Api.Extensions;

public static class ApplicationBuilderExtensions
{
    public static void AddMigrations(this IApplicationBuilder app)
    {
        using var scope = app.ApplicationServices.CreateScope();

        using var dbContext = scope.ServiceProvider.GetRequiredService<CharactersDbContext>();

        dbContext.Database.Migrate();
    }
}
