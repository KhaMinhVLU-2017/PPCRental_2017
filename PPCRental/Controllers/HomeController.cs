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

        [HttpGet]
        public ActionResult Search(string search = "")
        {
            var result = db.PROPERTies.ToList().Where(s => s.PropertyName.Contains(search));
            return View(result);
        }

        public ActionResult SearchCodeType(string type = "")
        {
            var result = db.PROPERTY_TYPE.FirstOrDefault(s=>s.CodeType.Contains(type));
            var rs = db.PROPERTies.Where(s => s.PropertyType_ID == result.ID).ToList();
            return View(rs);
        }

        [HttpGet]
        public ActionResult GetCodeType()
        {

            List<ListDB> lstCus = new List<ListDB>();
            //var result = pms.Database.SqlQuery<CustomerGroup>("MM_CustomerGroup").ToList();
            var result = db.Database.SqlQuery<ListDB>("PPC_GetCodeType").ToList();
            foreach (var item in result)
            {
                lstCus.Add(new ListDB()
                {
                    CodeType = item.CodeType
                });
            }
            return Json(lstCus, JsonRequestBehavior.AllowGet);
        }
    }
}