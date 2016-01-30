namespace YouTubePlaylist.Data.Migrations
{
    using Common.Constatnts;
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using Models;
    using System.Collections.Generic;
    using System.Data.Entity.Migrations;
    using System.Linq;

    public sealed class Configuration : DbMigrationsConfiguration<YouTubePlaylistDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(YouTubePlaylistDbContext context)
        {
            if (context.Playlists.Any())
            {
                return;
            }

            var users = new List<User>();

            if (!context.Roles.Any(r => r.Name == "Administrator"))
            {
                var store = new RoleStore<IdentityRole>(context);
                var manager = new RoleManager<IdentityRole>(store);
                var role = new IdentityRole { Name = "Administrator" };

                manager.Create(role);
            }

            if (!context.Users.Any(u => u.UserName == "admin"))
            {
                var store = new UserStore<User>(context);
                var manager = new UserManager<User>(store);
                manager.PasswordValidator = new PasswordValidator
                {
                    RequiredLength = 5,
                    RequireNonLetterOrDigit = false,
                    RequireDigit = false,
                    RequireLowercase = false,
                    RequireUppercase = false,
                };

                var admin = new User
                {
                    UserName = "admin@site.com",
                    Email = "admin@site.com",
                    FirstName = "admin",
                    LastName = "admin"

                };

                var se = manager.Create(admin, "admin");
                context.SaveChanges();
                manager.AddToRole(admin.Id, "Administrator");
                context.SaveChanges();

                for (int i = 1; i <= 5; i++)
                {
                    var user = new User
                    {
                        UserName = "user" + i + "@site.com",
                        Email = "admin@site.com",
                        FirstName = "user" + i,
                        LastName = "user" + i,
                        ImageUrl = UserConstants.DefaultImageURl
                    };

                    manager.Create(user, "user" + i);
                    users.Add(user);
                }

                context.SaveChanges();
            }

            var seed = new SeedData(users);

            seed.Playlist.ForEach(x => context.Playlists.Add(x));

            context.SaveChanges();
        }
    }
}
