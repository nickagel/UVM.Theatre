using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace UVM.Theatre
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
              name: "Location",
              url: "Location",
              defaults: new { controller = "Theatre", action = "Location" }
            );

            routes.MapRoute(
              name: "Archive",
              url: "Archive",
              defaults: new { controller = "Theatre", action = "Archive" }
            );
            routes.MapRoute(
              name: "Shows",
              url: "Shows",
              defaults: new { controller = "Theatre", action = "Shows" }
            );


            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Theatre", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
