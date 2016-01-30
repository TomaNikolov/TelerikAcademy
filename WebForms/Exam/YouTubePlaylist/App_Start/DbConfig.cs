namespace YouTubePlaylist.App_Start
{
    using YouTubePlaylist.Data;
    using System.Data.Entity;
    using YouTubePlaylist.Data.Migrations;

    public class DbConfig
    {
        public static void Initialize()
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<YouTubePlaylistDbContext, Configuration>());

            YouTubePlaylistDbContext.Create().Database.Initialize(true);
        }
    }
}