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



      //      routes.MapRoute(
      //     name: "Trang chu",
      //     url: "Trang-chu",
      //     defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
      //     );

          
      //      routes.MapRoute(
      //       name: "About Introduction",
      //       url: "Trang-chu/gioi-thieu",
      //       defaults: new { controller = "Home", action = "Aboutus", id = UrlParameter.Optional }
      //       );

      //      routes.MapRoute(
      //          name: "Account",
      //          url: "Tai-khoan/dang-nhap",
      //          defaults: new { controller = "Home", action = "Login", id = UrlParameter.Optional }
      //      );
      //      routes.MapRoute(
      //       name: "Fillter loai bat dong san",
      //        url: "{Timkiem}/{loaibatdongsan}/{type}-{name}",
      //           defaults: new { controller = "Home", action = "SearchCodeType", id = UrlParameter.Optional },
      //           namespaces: new[] { "HomeController" }
      //           );

      //      routes.MapRoute(
      //         name: "Search District",
      //         url: "Tim-kiem/Quan-{districtid}-{name}",
      //         defaults: new { controller = "Home", action = "SearchDistrict", id = UrlParameter.Optional }
      //         );
      //      routes.MapRoute(
      //    name: "Product Detail",
      //    url: "{NameController}/{metatitle}-{id}",
      //    defaults: new { controller = "Home", action = "Detail", id = UrlParameter.Optional }
      //);
            routes.MapRoute(
             name: "Default",
             url: "{controller}/{action}/{id}",
             defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
         );

        }
    }
}
