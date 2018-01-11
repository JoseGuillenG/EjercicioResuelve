using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace CustomerInvoicesWeb
{
    /// <summary>
    /// Clase que controla las rutas en el sistema
    /// </summary>
    public class RouteConfig
    {
        /// <summary>
        /// Método que registra las rutas
        /// </summary>
        /// <param name="routes"></param>
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
