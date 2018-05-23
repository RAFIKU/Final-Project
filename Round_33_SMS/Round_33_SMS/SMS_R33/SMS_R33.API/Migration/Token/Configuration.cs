namespace SMS_R33.API.Migration.Token
{
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using SMS_R33.API.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<SMS_R33.API.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            MigrationsDirectory = @"Migration\Token";
        }

        protected override void Seed(SMS_R33.API.Models.ApplicationDbContext context)
        {
            var userManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(context));
            if (!context.Users.Any(u => u.UserName == "admin@school.com"))
            {
                var u = new ApplicationUser { UserName = "admin@school.com" };
                var result = userManager.Create(u, "@Open1234");

            }
        }
    }
}
