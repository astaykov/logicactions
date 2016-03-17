using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LegacyWebAsmx.Startup))]
namespace LegacyWebAsmx
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
