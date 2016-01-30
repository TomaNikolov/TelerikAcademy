
using YouTubePlaylist.Models;

namespace YouTubePlaylist.Services.Contracts
{
    public interface IUserServices
    {
        User GetById(string userId);
    }
}
