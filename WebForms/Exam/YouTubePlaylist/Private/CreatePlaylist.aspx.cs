namespace YouTubePlaylist.Private
{
    using Ninject;
    using System;
    using System.Linq;
    using Microsoft.AspNet.Identity;
    using YouTubePlaylist.Models;
    using YouTubePlaylist.Services.Contracts;

    public partial class CreatePlaylist : System.Web.UI.Page
    {

        [Inject]
        public ICategoryServices CategoryServices { get; set; }

        [Inject]
        public IPlayListServices PlaylistServices { get; set; }



        protected void btnCreatePlaylist_Click(object sender, EventArgs e)
        {
            var userId = this.User.Identity.GetUserId();
            var playlist = new Playlist()
            {
                UserId = this.User.Identity.GetUserId(),
                Title = this.tbTitle.Text,
                Description = this.tbDescription.Text,
                CategoryId = int.Parse(this.ddlCategories.SelectedValue),
                CreatedOn = DateTime.UtcNow,
            };

            if (!string.IsNullOrEmpty(tbVideo.Text))
            {
                var video = new Video()
                {
                    Url = tbVideo.Text
                };

                playlist.Videos.Add(video);
            }

           var newPlaylist =  this.PlaylistServices.Create(playlist);

            this.Response.Redirect("~/PlayListDetatils?Id=" + newPlaylist.Id);
        }

        public IQueryable<Category> ddlCategories_GetData()
        {
            return this.CategoryServices.GetAll();
        }
    }
}