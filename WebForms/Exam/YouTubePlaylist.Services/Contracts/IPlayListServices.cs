namespace YouTubePlaylist.Services.Contracts
{
    using System.Collections.Generic;
    using System.Linq;
    using YouTubePlaylist.Models;

    public interface IPlayListServices
    {
        IQueryable<Playlist> GetAll();

        IQueryable<Playlist> GetMostPopular(int count);

        Playlist GetById(int id);

        IEnumerable<Playlist> GetByCategory(int categoryId);

        IEnumerable<Playlist> GetByCategoryName(string categoryName);

        IEnumerable<Playlist> GetPlaylistByUserId(string userId);

        Playlist Create(Playlist playlist);
    }
}
