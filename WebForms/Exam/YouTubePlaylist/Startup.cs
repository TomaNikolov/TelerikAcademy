using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(YouTubePlaylist.Startup))]
namespace YouTubePlaylist
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
