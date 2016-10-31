using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(E_Commrece.Startup))]
namespace E_Commrece
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
