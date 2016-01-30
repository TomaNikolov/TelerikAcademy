namespace YouTubePlaylist.Private
{
    using Ninject;
    using System;
    using System.Web.Providers.Entities;
    using Microsoft.AspNet.Identity;
    using YouTubePlaylist.Services.Contracts;
    using System.Collections.Generic;
    using Models;
    public partial class ProfilePage : System.Web.UI.Page
    {
        [Inject]
        public IUserServices userServices { get; set; }

        [Inject]
        public IPlayListServices playListServices { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        // The id parameter should match the DataKeyNames value set on the control
        // or be decorated with a value provider attribute, e.g. [QueryString]int id
        public YouTubePlaylist.Models.User fvProfile_GetItem()
        {
            var userId = this.User.Identity.GetUserId();

           return  this.userServices.GetById(userId);
        }

        public IEnumerable<Playlist> rptPlaylists_GetData()
        {
            var userId = this.User.Identity.GetUserId();
            return this.playListServices.GetPlaylistByUserId(userId);
        }

        // The id parameter name should match the DataKeyNames value set on the control
        public void fvProfile_UpdateItem(string id)
        {
            YouTubePlaylist.Models.User item = null;
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
    }
}