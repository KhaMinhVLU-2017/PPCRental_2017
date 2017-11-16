using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PPCRental.Models;

namespace PPCRental.Controllers
{
    public class HomeController : Controller
    {
        PPCRentalEntities db = new PPCRentalEntities();
        public ActionResult Index()
        {
            var result = db.PROPERTies.ToList();
            return View(result);
        }

        public ActionResult About()
        {

            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }
        public ActionResult Aboutus()
        {
            return View();
        }
    }
}