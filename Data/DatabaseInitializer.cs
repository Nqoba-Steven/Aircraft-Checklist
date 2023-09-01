using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using NAC_Aircraft_Checklist.Models;
using NAC_Aircraft_Checklist.Models.Entities;

namespace NAC_Aircraft_Checklist.Data
{
    public class DatabaseInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();

                context.Database.EnsureCreated();
                
            }
        }
    }
}
