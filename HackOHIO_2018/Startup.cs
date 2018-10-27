using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HackOHIO_2018.Startup))]
namespace HackOHIO_2018
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
