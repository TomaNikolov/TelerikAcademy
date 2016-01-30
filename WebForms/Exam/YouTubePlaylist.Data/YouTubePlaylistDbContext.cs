namespace YouTubePlaylist.Data
{
    using System;
    using System.Data.Entity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using YouTubePlaylist.Models;
    public class YouTubePlaylistDbContext : IdentityDbContext<User>, IYouTubePlaylistDbContext
    {
        public YouTubePlaylistDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public IDbSet<Playlist> Playlists { get; set; }

        public IDbSet<Category> Categories { get; set; }

        public IDbSet<Rating> Ratings{ get; set; }

        public IDbSet<Video> Videos { get; set; }

        public static YouTubePlaylistDbContext Create()
        {
            return new YouTubePlaylistDbContext();
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder
                .Entity<Video>()
                .HasRequired(p => p.Playlist)
                .WithMany(x => x.Videos)
                .WillCascadeOnDelete(true);

            base.OnModelCreating(modelBuilder);
        }
    }
}
