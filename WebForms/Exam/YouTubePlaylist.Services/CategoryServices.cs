namespace YouTubePlaylist.Services
{
    using System.Linq;
    using YouTubePlaylist.Data.Repositories;
    using YouTubePlaylist.Models;
    using YouTubePlaylist.Services.Contracts;

    public class CategoryServices : ICategoryServices
    {

        private IRepository<Category> categories;

        public CategoryServices(IRepository<Category> categories)
        {
            this.categories = categories;
        }

        public void Create(Category category)
        {
            this.categories.Add(category);
            this.categories.SaveChanges();
        }

        public void Delete(int id)
        {
            this.categories.Delete(id);
            this.categories.SaveChanges();
        }

        public IQueryable<Category> GetAll()
        {
            return this.categories.All().OrderBy(x => x.Id);
        }

        public Category GetById(int id)
        {
            return this.categories.GetById(id);
        }

        public void Update(Category category)
        {
            this.categories.SaveChanges();
        }
    }
}
