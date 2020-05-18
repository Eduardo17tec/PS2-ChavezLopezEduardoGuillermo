using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PS2_ChavezLopezEduardoGuillermo.Startup))]
namespace PS2_ChavezLopezEduardoGuillermo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
