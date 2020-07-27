using DSS.Api.Data;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace DSS.Api.Services.Startup {
    internal static class DbMigratorExtensions {
        internal static void UpdateDatabase(
                this IApplicationBuilder app,
                IConfiguration config) {

            using var serviceScope = app.ApplicationServices
                .GetRequiredService<IServiceScopeFactory>()
                .CreateScope();

            using var context = serviceScope.ServiceProvider.GetService<DSSDbContext>();
            context.Database.Migrate();
            // DSSDbContextInitialiser.SeedUsers(userManager, context, config);
        }
    }
}
