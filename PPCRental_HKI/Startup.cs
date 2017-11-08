using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PPCRental_HKI.Startup))]
namespace PPCRental_HKI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
