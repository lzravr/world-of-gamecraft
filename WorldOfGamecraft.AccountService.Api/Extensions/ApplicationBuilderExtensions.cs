using Microsoft.EntityFrameworkCore;
using WorldOfGamecraft.AccountService.Infrastructure;

namespace WorldOfGamecraft.AccountService.Api.Extensions;

public static class ApplicationBuilderExtensions
{
    public static void AddMigrations(this IApplicationBuilder app)
    {
        using var scope = app.ApplicationServices.CreateScope();

        using var dbContext = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();

        dbContext.Database.Migrate();
    }
}
