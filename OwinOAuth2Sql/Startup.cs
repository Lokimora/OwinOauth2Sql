using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Http.Routing;
using Microsoft.Owin;
using Owin;
using OwinOAuth2Sql;

[assembly: OwinStartup(typeof(Startup))]
namespace OwinOAuth2Sql
{ 
    public class Startup
    {
        public void Configuration(IAppBuilder appBuilder)
        {

            var server = new HttpConfiguration();
            server.Routes.MapHttpRoute(
                name: "default",
                routeTemplate: "{controller}/{action}/id"
                );


            appBuilder.UseWebApi(server);
        }

        public void ConfigureOauth(IAppBuilder builder)
        {
            
        }
    }
}