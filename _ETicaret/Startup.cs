using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_ETicaret.Startup))]
namespace _ETicaret
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
