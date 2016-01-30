using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.ModelBinding;
using System.Web.UI;
using System.Web.UI.WebControls;
using YouTubePlaylist.Models;
using YouTubePlaylist.Services.Contracts;

namespace YouTubePlaylist
{
    public partial class PlaylistByCategory : System.Web.UI.Page
    {
        [Inject]
        public IPlayListServices playListServices { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public IEnumerable<Playlist> rptPopularPlaylists_GetData([QueryString("categoryName")]string categoryName)
        {
           
            if (categoryName == null)
            {
                this.Response.Redirect("~/");
            }
            this.ltrCategoryName.Text = categoryName;
            return this.playListServices.GetByCategoryName(categoryName);
        }
    }
}