using System.Web.Http;
using ScratchAPI.Infrastructure;

namespace ScratchAPI
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            Bootstrapper.Start();
            config.DependencyResolver = new DependencyResolver();
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }

    
}
