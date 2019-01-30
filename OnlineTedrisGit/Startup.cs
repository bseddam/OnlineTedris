using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(OnlineTedrisGit.Startup))]
namespace OnlineTedrisGit
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
