namespace YouTubePlaylist
{
    using System;
    using Ninject;
    using YouTubePlaylist.Services.Contracts;
    using System.Collections.Generic;
    using Models;
    public partial class Home : System.Web.UI.Page
    {
        [Inject]
        public IPlayListServices playListServices { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
        }

        public IEnumerable<Playlist> rptPopularPlaylists_GetData()
        {
           return this.playListServices.GetMostPopular(10);
        }
    }
}