namespace YouTubePlaylist
{
    using Models;
    using Ninject;
    using Services.Contracts;
    using System;
    using System.Web.ModelBinding;
    public partial class PlaylistDetails : System.Web.UI.Page
    {
        [Inject]
        public IPlayListServices playListServices { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        // The id parameter should match the DataKeyNames value set on the control
        // or be decorated with a value provider attribute, e.g. [QueryString]int id
        public Playlist fvPlaylistDetails_GetItem([QueryString("id")]string id)
        {
            var playlistId = 0;

            if (!int.TryParse(id, out playlistId))
            {
                this.Response.Redirect("~/");
            }

            return this.playListServices.GetById(playlistId);
        }

        // The id parameter name should match the DataKeyNames value set on the control
        public void fvPlaylistDetails_UpdateItem(int id)
        {
            YouTubePlaylist.Models.Playlist item = null;
            // Load the item here, e.g. item = MyDataLayer.Find(id);
            if (item == null)
            {
                // The item wasn't found
                ModelState.AddModelError("", String.Format("Item with id {0} was not found", id));
                return;
            }
            TryUpdateModel(item);
            if (ModelState.IsValid)
            {
                // Save changes here, e.g. MyDataLayer.SaveChanges();

            }
        }
        public string GetUrls(string url)
        {
            var urlIdent =   url.Substring(url.LastIndexOf('=') + 1);

            return urlIdent;
        }
    }
}