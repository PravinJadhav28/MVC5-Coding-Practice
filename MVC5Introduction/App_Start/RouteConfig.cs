﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MVC5Introduction
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.MapMvcAttributeRoutes();

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Products", action = "Create", id = UrlParameter.Optional }
            );

            //routes.MapRoute(
            //    name: "Default1",
            //    url: "{controller}/{action}/{id}/{rollnumber}",
            //    defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional, rollnumber = UrlParameter.Optional }
            //);
        }
    }
}
