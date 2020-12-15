using System;
using System.Threading.Tasks;
using Microsoft.Owin;
using Microsoft.Owin.Security;
using Microsoft.Owin.Security.Cookies;
using Owin;

[assembly: OwinStartup(typeof(EndOfSemester3.Startup))]


namespace EndOfSemester3
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.UseKentorOwinCookieSaver();

            // Set Cookies as default authentication type
            app.SetDefaultSignInAsAuthenticationType(CookieAuthenticationDefaults.AuthenticationType);
            app.UseCookieAuthentication(new CookieAuthenticationOptions
            {
                AuthenticationType = CookieAuthenticationDefaults.AuthenticationType,
                LoginPath = new PathString("/Account/Login")
            });
            app.MapSignalR();
            ConfigureAuth(app);
        }
    }
}
