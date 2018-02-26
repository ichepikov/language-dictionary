using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(LanguageDictionary.MobileAppService.Startup))]

namespace LanguageDictionary.MobileAppService
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureMobileApp(app);
        }
    }
}