using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace PPCRental
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");


            routes.MapRoute(
             name: "Fillter loai bat dong san",
              url: "Tim-kiem/loai-bat-dong-san/{type}-{name}",
                 defaults: new { controller = "Home", action = "SearchCodeType", id = UrlParameter.Optional }
                 );

            routes.MapRoute(
           name: "Trang chu",
           url: "Trang-chu",
           defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
           );
            routes.MapRoute(
             name: "About Introduction",
             url: "Trang-chu/gioi-thieu",
             defaults: new { controller = "Home", action = "Aboutus", id = UrlParameter.Optional }
             );
            routes.MapRoute(
                name: "Account",
                url: "Tai-khoang/dang-nhap",
                defaults: new { controller = "Account", action = "Login", id = UrlParameter.Optional }
            );
            routes.MapRoute(
              name: "Product Detail",
              url: "Chi-tiet/{metatitle}-{id}",
              defaults: new { controller = "Home", action = "Detail", id = UrlParameter.Optional }
          );
            routes.MapRoute(
             name: "Default",
             url: "{controller}/{action}/{id}",
             defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
         );

        }
    }
}
