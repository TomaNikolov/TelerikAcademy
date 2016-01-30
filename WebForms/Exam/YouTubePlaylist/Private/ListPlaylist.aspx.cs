namespace YouTubePlaylist.Private
{
    using System;
    using System.Linq;
    using System.Web.ModelBinding;
    using System.Linq.Dynamic;
    using Ninject;
    using YouTubePlaylist.Models;
    using YouTubePlaylist.Services.Contracts;
    using System.Collections.Generic;
    public partial class ListPlaylist : System.Web.UI.Page
    {
        private IDictionary<string, string> sort = new Dictionary<string, string>() { { "Date", "CreatedOn" }, { "Name", "Title" }, { "Rating", "Ratings.Average(x => x.Value)" }, };

        [Inject]
        public ICategoryServices CategoryServices { get; set; }

        [Inject]
        public IPlayListServices PlaylistServices { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
        }

        public IQueryable<Playlist> lvArticles_GetData([QueryString("q")] string searchQueery, [QueryString("orderBy")] string sortQuery)
        {
            var result = this.PlaylistServices.GetAll();
            if (sortQuery != null && sort.ContainsKey(sortQuery))
            {
                if(sortQuery == "Rating")
                {
                    result = result.OrderBy(pl => pl.Ratings.Average(x => x.Value));
                }
                else
                {
                    result = result.OrderBy(sort[sortQuery] + " " + "Ascending");
                }
            }

            if (searchQueery != null)
            {
                result = result.Where(pl => pl.Title.ToLower().Contains(searchQueery) || pl.Description.ToLower().Contains(searchQueery));
            }

            return result;
        }

        public IQueryable<Category> ddlInsertCategory_GetData()
        {
            return this.CategoryServices.GetAll();
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            var text = this.tbSearch.Text;

            this.Response.Redirect("~//Private/ListPlaylist.aspx?q=" + text);
        }
    }

}