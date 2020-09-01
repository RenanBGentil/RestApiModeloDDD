using System;
using System.Collections.Generic;
using System.Text;
using Owin;
using System.Web.Http;

namespace RestApiModeloDDD.Console
{
    public class Startup
    {
        public void Configuration(IAppBuilder appBuilder)
        {
             
            HttpConfiguration config = new HttpConfiguration();
            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            appBuilder.UseWebApi(config);
        }
    }
}
