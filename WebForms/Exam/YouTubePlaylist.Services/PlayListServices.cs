namespace YouTubePlaylist.Services
{
    using System.Collections.Generic;
    using System.Linq;
    using Data.Repositories;
    using Models;
    using YouTubePlaylist.Services.Contracts;

    public class PlayListServices : IPlayListServices
    {
        private IRepository<Playlist> playlists;

        public PlayListServices(IRepository<Playlist> playlists)
        {
            this.playlists = playlists;
        }

        public Playlist Create(Playlist playlist)
        {
            this.playlists.Add(playlist);

            this.playlists.SaveChanges();

            return playlist;
        }

        public IQueryable<Playlist> GetAll()
        {
            return this.playlists.All();
        }

        public IEnumerable<Playlist> GetByCategory(int categoryId)
        {
            return this.playlists.All().Where(pl => pl.CategoryId == categoryId);
        }

        public IEnumerable<Playlist> GetByCategoryName(string categoryName)
        {
            return this.playlists.All().Where(pl => pl.Category.Name == categoryName);
        }

        public Playlist GetById(int id)
        {
            return this.playlists.GetById(id);
        }

        public IQueryable<Playlist> GetMostPopular(int count)
        {
            return this.playlists.All()
                .OrderByDescending(p => p.Ratings.Average(r => r.Value));
        }

        public IEnumerable<Playlist> GetPlaylistByUserId(string userId)
        {
            return this.playlists.All().Where(pl => pl.UserId == userId);
        }
    }
}
