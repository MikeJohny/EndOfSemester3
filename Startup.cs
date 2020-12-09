using System;
using System.Threading.Tasks;
using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(EndOfSemester3.Startup))]
[assembly: OwinStartupAttribute(typeof(EndOfSemester3.Startup))]

namespace EndOfSemester3
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.MapSignalR();
            ConfigureAuth(app);
        }
    }
}
