using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HrAppDataAcces.Entities;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
namespace HrAppDataAcces
{
    public static class PrepDb
    {
        public static void PrepPopulation(IApplicationBuilder app)
        {
            using (var serviceScope = app.ApplicationServices.CreateScope())
            {
                SeedData(serviceScope.ServiceProvider.GetService<DataBaseContext>());
            }
        }
        private static void SeedData(DataBaseContext dbContext)
        {
            if (!dbContext.Users.Any())
            {
                Console.WriteLine("--> seeding data ...");
                dbContext.Users.AddRange(
                    new User() { },
                    new User() {  },
                    new User() {  }
                    );
                dbContext.SaveChanges();

            }
            else
            {
                Console.WriteLine("--> we already have data");
            }
        }
    }
}
