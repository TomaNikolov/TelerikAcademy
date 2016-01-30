namespace YouTubePlaylist.Services
{
    using System;
    using Models;
    using YouTubePlaylist.Services.Contracts;
    using Data.Repositories;
    using System.Linq;

    public class UserServices : IUserServices
    {
        private IRepository<User> users;

        public UserServices(IRepository<User> users)
        {
            this.users = users;
        }

        public User GetById(string userId)
        {
            return this.users.All().FirstOrDefault(u => u.Id == userId);
        }
    }
}
