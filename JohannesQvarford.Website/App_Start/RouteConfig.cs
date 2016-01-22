﻿namespace JohannesQvarford.Website
{
    using System.Web.Mvc;
    using System.Web.Routing;

    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.LowercaseUrls = true;
            routes.MapRoute(
                name: "Projects",
                url: "projects/{title}",
                defaults: new { controller = "Projects", action = "GetProject" });
            routes.MapRoute(
                name: "Default",
                url: "{action}",
                defaults: new { controller = "Home", action = "Index" }
            );
        }
    }
}