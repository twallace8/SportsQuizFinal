using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FridayQuizz.Startup))]
namespace FridayQuizz
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
