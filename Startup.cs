using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebImageDataUrl.Startup))]
namespace WebImageDataUrl
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
