using Microsoft.EntityFrameworkCore;
using MyApp.Infrastucture.Data;

namespace MyApp.WebApp.Extentions;

public static class MigrateExtentions
{
    public static async Task ApplyMigrationAsync(this IApplicationBuilder app, ILogger logger)
    {
        using var scope = app.ApplicationServices.CreateScope();

        var context = scope.ServiceProvider.GetRequiredService<MyAppDbContext>();
        await context.Database.MigrateAsync();
    }
}
