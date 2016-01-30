namespace YouTubePlaylist.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Security.Claims;
    using System.Threading.Tasks;

    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;

    public class User : IdentityUser
    {
        private ICollection<Rating> ratings;

        public User()
        {
            this.ratings = new HashSet<Rating>();
        }

        [Required]
        [MinLength(2)]
        [MaxLength(200)]
        public string FirstName { get; set; }

        [Required]
        [MinLength(2)]
        [MaxLength(200)]
        public string LastName { get; set; }

        public string ImageUrl { get; set; }

        public string FacebookUrl { get; set; }

        public string YouTubeUrl { get; set; }

        public ICollection<Rating> Ratings
        {
            get { return this.ratings; }
            set { this.ratings = value; }
        }

        public ClaimsIdentity GenerateUserIdentity(UserManager<User> manager)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = manager.CreateIdentity(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Add custom user claims here
            return userIdentity;
        }

        public Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<User> manager)
        {
            return Task.FromResult(GenerateUserIdentity(manager));
        }
    }
}
