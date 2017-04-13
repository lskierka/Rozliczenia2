using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Rozliczenia.Startup))]
namespace Rozliczenia
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
