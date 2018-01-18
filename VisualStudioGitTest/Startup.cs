using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(VisualStudioGitTest.Startup))]
namespace VisualStudioGitTest
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
