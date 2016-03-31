using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(JondickPlayGoExam.Startup))]
namespace JondickPlayGoExam
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
