using Microsoft.EntityFrameworkCore;
using Polly;
using WorldOfGamecraft.CharacterService.Infrastructure;

namespace WorldOfGamecraft.CharacterService.Api.Extensions;

public static class ApplicationBuilderExtensions
{
    public static void AddMigrations(this IApplicationBuilder app)
    {
        using var scope = app.ApplicationServices.CreateScope();

        using var dbContext = scope.ServiceProvider.GetRequiredService<CharactersDbContext>();

        var retryPolicy = Policy.Handle<Exception>().WaitAndRetry(3, retryAttemp => TimeSpan.FromSeconds(5));

        retryPolicy.Execute(() =>
        {
            dbContext.Database.Migrate();
        });
    }
}
