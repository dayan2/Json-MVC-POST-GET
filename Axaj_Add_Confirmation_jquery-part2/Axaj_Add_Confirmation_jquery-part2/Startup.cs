using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Axaj_Add_Confirmation_jquery_part2.Startup))]
namespace Axaj_Add_Confirmation_jquery_part2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
