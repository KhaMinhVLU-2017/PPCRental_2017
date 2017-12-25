using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PPCRental.Models;
using System.Data.SqlClient;

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
        public ActionResult Contact1()
        {
            return View();
        }
        public ActionResult News()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(string email, string password)
        {
            var rs = db.USERs.FirstOrDefault(s => s.Email == email);
            if (rs != null)
            {
                if (rs.Password.Equals(password))
                {
                    Session["Fullname"] = rs.FullName;
                    Session["UserID"] = rs.ID;
                    Session["RoleID"] = rs.Role;
                    if (int.Parse(rs.Role) == 0)
                    {
                        return RedirectToAction("Index", "Agency");
                    }
                    else
                    {
                        return View();
                    }
                   
                }
            }
            else
            {
                ViewBag.mess = "Account not exist";
            }
            return View();
        }

        public ActionResult Logout(int id)
        {
            var user = db.USERs.FirstOrDefault(s => s.ID == id);
            if (user != null)
            {
                Session["Fullname"] = null;
                Session["UserID"] = null;
                Session["RoleID"] = null;
            }
            return RedirectToAction("Login");
        }
        [HttpGet]
        public ActionResult SignUp()
        {
            return View();
        }

        [HttpPost]
        public ActionResult SignUp(string fullname, string email, string address, string password, string phonenumber)
        {
            var us = new USER();
            us.FullName = fullname;
            us.Email = email;
            us.Address = address;
            us.Password = password;
            us.Phone = phonenumber;
            db.USERs.Add(us);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Search(string search = "")
        {
            var result = db.PROPERTies.ToList().Where(s => s.PropertyName.Contains(search));
            return View(result);
        }

        public ActionResult SearchCodeType(string type = "", string name = "")
        {
            ViewBag.Name = name;
            var result = db.PROPERTY_TYPE.FirstOrDefault(s=>s.CodeType.Contains(type));
            var rs = db.PROPERTies.Where(s => s.PropertyType_ID == result.ID).ToList();
            return View(rs);
        }

        public ActionResult SearchFeature(int featureid, string name ="")
        {
            ViewBag.Name = name;
            var result = db.FEATUREs.FirstOrDefault(s => s.ID == featureid);
            var ft = db.PROPERTY_FEATURE.Where(s=>s.Feature_ID == result.ID).ToList();
            return View(ft);
        }

        public ActionResult SearchDistrict(int districtid, string name="")
        {
            ViewBag.Name = name;
            var result = db.DISTRICTs.FirstOrDefault(s=>s.ID == districtid);
            var dt = db.PROPERTies.Where(s => s.District_ID == result.ID).ToList();
            return View(dt);
        }
        [HttpGet]
        public ActionResult GetDistrict()
        {

            List<ListDB> lstCus = new List<ListDB>();
            var result = db.Database.SqlQuery<ListDB>("PPC_District").ToList();
            foreach (var item in result)
            {
                lstCus.Add(new ListDB()
                {
                    DistrictName = item.DistrictName
                });
            }
            return Json(lstCus, JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        public JsonResult GetWard(string District = "")
        {
            List<ListWard> lstCus = new List<ListWard>();
            var district = new SqlParameter("@DistrictName", District);
            var result = db.Database.SqlQuery<ListWard>("PPC_Ward @DistrictName", district).ToList();
            foreach (var item in result)
            {
                lstCus.Add(new ListWard()
                {
                    WardName = item.WardName
                });
            }
            return Json(lstCus, JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        public JsonResult GetStreet(string District = "")
        {
            List<ListStreet> lstCus = new List<ListStreet>();
            var district = new SqlParameter("@DistrictName", District);
            var result = db.Database.SqlQuery<ListStreet>("PPC_Street @DistrictName", district).ToList();
            foreach (var item in result)
            {
                lstCus.Add(new ListStreet()
                {
                    StreetName = item.StreetName
                });
            }
            return Json(lstCus, JsonRequestBehavior.AllowGet);
        }
        public ActionResult Detail(int id)
        {
            ViewData["AllPro"] = db.PROPERTies.ToList();
             PROPERTY meo = new PROPERTY();		
             meo = db.PROPERTies.FirstOrDefault(s =>s.ID == id);		
             return View(meo);
        }

    }
}