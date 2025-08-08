using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Store.Model.Persistence;

public static class PersistenceExtensions
{
    public static async Task UseMigrationsAsync(this IServiceProvider serviceProvider)
    {
        await using var scope = serviceProvider.CreateAsyncScope();
        
        var persistence = scope.ServiceProvider.GetRequiredService<Persistence>();
        await persistence.Database.EnsureCreatedAsync();
        await persistence.Database.MigrateAsync();
    }
}