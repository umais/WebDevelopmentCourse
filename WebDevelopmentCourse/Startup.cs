using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebDevelopmentCourse.Startup))]
namespace WebDevelopmentCourse
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
