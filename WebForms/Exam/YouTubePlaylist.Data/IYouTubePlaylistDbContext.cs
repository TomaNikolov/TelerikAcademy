namespace YouTubePlaylist.Data
{
    using Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;

    public interface IYouTubePlaylistDbContext : IDisposable
    {
        int SaveChanges();

        IDbSet<User> Users { get; set; }

        IDbSet<Playlist> Playlists { get; set; }

        IDbSet<Category> Categories { get; set; }

        IDbSet<Rating> Ratings { get; set; }

        IDbSet<Video> Videos { get; set; }

        DbSet<TEntity> Set<TEntity>() where TEntity : class;

        DbEntityEntry<TEntity> Entry<TEntity>(TEntity entity) where TEntity : class;
    }
}
