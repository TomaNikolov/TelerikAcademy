namespace YouTubePlaylist.Services.Contracts
{
    using System.Linq;
    using YouTubePlaylist.Models;

    public interface ICategoryServices
    {
        IQueryable<Category> GetAll();

        Category GetById(int id);

        void Update(Category category);

        void Delete(int id);

        void Create(Category category);
    }
}
