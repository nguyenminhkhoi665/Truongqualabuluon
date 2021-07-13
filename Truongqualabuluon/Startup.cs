using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Truongqualabuluon.Startup))]
namespace Truongqualabuluon
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
