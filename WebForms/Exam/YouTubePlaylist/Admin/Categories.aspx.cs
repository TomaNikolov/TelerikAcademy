using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using YouTubePlaylist.Models;
using YouTubePlaylist.Services.Contracts;

namespace YouTubePlaylist.Admin
{
    public partial class Categories : System.Web.UI.Page
    {
        [Inject]
        public ICategoryServices categoryServices { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        // The return type can be changed to IEnumerable, however to support
        // paging and sorting, the following parameters must be added:
        //     int maximumRows
        //     int startRowIndex
        //     out int totalRowCount
        //     string sortByExpression
        public IQueryable<Category> gvCategories_GetData()
        {
            return this.categoryServices.GetAll();
        }

        // The id parameter name should match the DataKeyNames value set on the control
        public void gvCategories_UpdateItem(int id)
        {
            var category = this.categoryServices.GetById(id);

            if (category == null)
            {
                ModelState.AddModelError("", String.Format("Item with id {0} was not found", id));
                return;
            }

            TryUpdateModel(category);
            if (ModelState.IsValid)
            {
                this.categoryServices.Update(category);
            }
        }

        // The id parameter name should match the DataKeyNames value set on the control
        public void gvCategories_DeleteItem(int id)
        {
            this.categoryServices.Delete(id);
        }

        protected void btnInsert_Click(object sender, EventArgs e)
        {
            var categoryName = this.tbCategoryInsert.Text;

            this.categoryServices.Create(new Category
            {
                Name = categoryName,
            });

            this.tbCategoryInsert.Text = "";
        }

        protected void tbnCancel_Click(object sender, EventArgs e)
        {
            this.tbCategoryInsert.Text = "";
        }
    }
}