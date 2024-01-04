using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace NghiemDangDuyThang_2020601070
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.MapMvcAttributeRoutes();//Câu 5
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                //Câu 2
                defaults: new { controller = "Management", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
