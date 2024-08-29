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
     new User()
     {
         Id = Guid.NewGuid(),
         Username = "user1",
         Id_AppUser = 1,
         APPUser = new APPUser() ,
         Password = "password"
     },
     new User()
     {
         Id = Guid.NewGuid(),
         Username = "user2",
         Id_AppUser = 2,
         APPUser = new APPUser(),
         Password = "password"

     },
     new User()
     {
         Id = Guid.NewGuid(),
         Username = "user3",
         Id_AppUser = 3,
         Password = "password",

         APPUser = new APPUser()
     },
     new User()
     {
         Id = Guid.NewGuid(),
         Username = "user4",
         Id_AppUser = 4,
         APPUser = new APPUser(),
         Password = "password"

     },
     new User()
     {
         Id = Guid.NewGuid(),
         Username = "user5",
         Id_AppUser = 5,
         APPUser = new APPUser(),
         Password = "password"

     }
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
