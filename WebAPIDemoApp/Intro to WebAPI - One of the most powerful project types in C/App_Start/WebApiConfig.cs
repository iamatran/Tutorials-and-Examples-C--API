using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace Intro_to_WebAPI___One_of_the_most_powerful_project_types_in_C
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

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
