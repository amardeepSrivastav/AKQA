using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using Unity;
using BAL;

namespace APIProject
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            //registering the component
            var container = new UnityContainer();
            container.RegisterType<IPersons, Persons>();
            config.DependencyResolver = new UnityResolver(container);
            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { controller ="Person",action = "ConvertNumber", id = RouteParameter.Optional }
            );
        }
    }
}
