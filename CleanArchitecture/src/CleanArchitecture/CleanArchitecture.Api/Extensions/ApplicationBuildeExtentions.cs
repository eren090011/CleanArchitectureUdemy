using CleanArchitecture.Infrastructure;
using Microsoft.EntityFrameworkCore;

namespace CleanArchitecturte.Api.Extensions;

public static class ApplicationBuilderExtentions{

    public static async void ApplyMigration(this IApplicationBuilder app){

        using (var scope = app.ApplicationServices.CreateScope())
        {
            var service = scope.ServiceProvider;
            var loggerFactory = service.GetRequiredService<ILoggerFactory>();

            try{
                var context = service.GetRequiredService<ApplicationDbContext>();
                await context.Database.MigrateAsync();
            }catch(Exception ex){
                var logger = loggerFactory.CreateLogger<Program>();
                logger.LogError(ex,"Error en migracion");
            }
        }
    }
}