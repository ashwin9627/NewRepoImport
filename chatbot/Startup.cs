using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(chatbot.Startup))]
namespace chatbot
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
