using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace Base64Action
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services
            // Add a reference here to the new MediaTypeFormatter that adds text/plain support
            config.Formatters.Insert(0, new Base64Action.Formatters.TextMediaTypeFormatter());
            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
