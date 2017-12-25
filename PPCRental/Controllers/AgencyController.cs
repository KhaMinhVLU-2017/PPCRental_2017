using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using PPCRental.Models;
using PagedList;
using Postal;
using System.Net.Mail;
using System.Reflection;

namespace PPCRental.Controllers
{
    public class AgencyController : Controller
    {
        private PPCRentalEntities db = new PPCRentalEntities();

        // GET: /Agency/
        public ActionResult Index(int? page = 1)
        {
            int pageSize = 7;
            int pageNumber = (page ?? 1);
            int userId = (int)Session["UserID"];
            var properties = db.PROPERTies.Where(s => s.UserID == userId).ToList();
            return View(properties.ToPagedList(pageNumber, pageSize));
        }

        // GET: /Agency/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PROPERTY property = db.PROPERTies.Find(id);
            if (property == null)
            {
                return HttpNotFound();
            }
            return View(property);
        }

        [AttributeUsage(AttributeTargets.Method, AllowMultiple = false, Inherited = true)]
        public class MultipleButtonAttribute : ActionNameSelectorAttribute
        {
            public string Name { get; set; }
            public string Argument { get; set; }

            public override bool IsValidName(ControllerContext controllerContext, string actionName, MethodInfo methodInfo)
            {
                var isValidName = false;
                var keyValue = string.Format("{0}:{1}", Name, Argument);
                var value = controllerContext.Controller.ValueProvider.GetValue(keyValue);

                if (value != null)
                {
                    controllerContext.Controller.ControllerContext.RouteData.Values[Name] = Argument;
                    isValidName = true;
                }

                return isValidName;
            }
        }

        // GET: /Agency/Create
        public ActionResult Create()
        {
            ViewBag.District_ID = new SelectList(db.DISTRICTs, "ID", "DistrictName");
            ViewBag.Status_ID = new SelectList(db.PROJECT_STATUS, "ID", "Status_Name");
            ViewBag.PropertyType_ID = new SelectList(db.PROPERTY_TYPE, "ID", "CodeType");
            ViewBag.Street_ID = new SelectList(db.STREETs, "ID", "StreetName");
            ViewBag.UserID = new SelectList(db.USERs, "ID", "Email");
            ViewBag.Sale_ID = new SelectList(db.USERs, "ID", "Email");
            ViewBag.Ward_ID = new SelectList(db.WARDs, "ID", "WardName");
            return View();
        }

        // POST: /Agency/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [MultipleButton(Name = "action", Argument = "Save")]
        public ActionResult Create(PROPERTY property)
        {
            if (ModelState.IsValid)
            {
               
                var prop = new PROPERTY();
                prop.PropertyName = property.PropertyName;
                prop.Avatar = property.Avatar;
                prop.Images = property.Images;
                prop.PropertyType_ID = property.PropertyType_ID;
                prop.Street_ID = property.Street_ID;
                prop.Ward_ID = property.Ward_ID;
                prop.District_ID = property.District_ID;
                prop.Price = property.Price;
                prop.Content = property.Content;
                prop.UnitPrice = property.UnitPrice;
                prop.Area = property.Area;
                prop.BathRoom = property.BathRoom;
                prop.BedRoom = property.BedRoom;
                prop.PackingPlace = property.PackingPlace;
                prop.UserID = int.Parse(Session["UserID"].ToString());
                prop.Created_at = DateTime.Now;
                prop.Status_ID = 1;
                db.PROPERTies.Add(prop);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
           
            return View(property);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [MultipleButton(Name = "action", Argument = "SaveDraft")]
        public ActionResult SaveDraft(PROPERTY property)
        {
            if (ModelState.IsValid)
            {

                var prop = new PROPERTY();
                prop.PropertyName = property.PropertyName;
                prop.Avatar = property.Avatar;
                prop.Images = property.Images;
                prop.PropertyType_ID = property.PropertyType_ID;
                prop.Street_ID = property.Street_ID;
                prop.Ward_ID = property.Ward_ID;
                prop.District_ID = property.District_ID;
                prop.Price = property.Price;
                prop.Content = property.Content;
                prop.UnitPrice = property.UnitPrice;
                prop.Area = property.Area;
                prop.BathRoom = property.BathRoom;
                prop.BedRoom = property.BedRoom;
                prop.PackingPlace = property.PackingPlace;
                prop.UserID = int.Parse(Session["UserID"].ToString());
                prop.Created_at = DateTime.Now;
                prop.Status_ID = 2;
                db.PROPERTies.Add(prop);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(property);
        }

        // GET: /Agency/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PROPERTY property = db.PROPERTies.Find(id);
            if (property == null)
            {
                return HttpNotFound();
            }
            ViewBag.District_ID = new SelectList(db.DISTRICTs, "ID", "DistrictName", property.District_ID);
            ViewBag.Status_ID = new SelectList(db.PROJECT_STATUS, "ID", "Status_Name", property.Status_ID);
            ViewBag.PropertyType_ID = new SelectList(db.PROPERTY_TYPE, "ID", "CodeType", property.PropertyType_ID);
            ViewBag.Street_ID = new SelectList(db.STREETs, "ID", "StreetName", property.Street_ID);
            ViewBag.UserID = new SelectList(db.USERs, "ID", "Email", property.UserID);
            ViewBag.Sale_ID = new SelectList(db.USERs, "ID", "Email", property.Sale_ID);
            ViewBag.Ward_ID = new SelectList(db.WARDs, "ID", "WardName", property.Ward_ID);
            return View(property);
        }

        // POST: /Agency/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include="ID,PropertyName,Avatar,Images,PropertyType_ID,Content,Street_ID,Ward_ID,District_ID,Price,UnitPrice,Area,BedRoom,BathRoom,PackingPlace,UserID,Created_at,Create_post,Status_ID,Note,Updated_at,Sale_ID")] PROPERTY property)
        {
            if (ModelState.IsValid)
            {
                db.Entry(property).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.District_ID = new SelectList(db.DISTRICTs, "ID", "DistrictName", property.District_ID);
            ViewBag.Status_ID = new SelectList(db.PROJECT_STATUS, "ID", "Status_Name", property.Status_ID);
            ViewBag.PropertyType_ID = new SelectList(db.PROPERTY_TYPE, "ID", "CodeType", property.PropertyType_ID);
            ViewBag.Street_ID = new SelectList(db.STREETs, "ID", "StreetName", property.Street_ID);
            ViewBag.UserID = new SelectList(db.USERs, "ID", "Email", property.UserID);
            ViewBag.Sale_ID = new SelectList(db.USERs, "ID", "Email", property.Sale_ID);
            ViewBag.Ward_ID = new SelectList(db.WARDs, "ID", "WardName", property.Ward_ID);
            return View(property);
        }

        // GET: /Agency/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PROPERTY property = db.PROPERTies.Find(id);
            if (property == null)
            {
                return HttpNotFound();
            }
            return View(property);
        }

        // POST: /Agency/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            PROPERTY property = db.PROPERTies.Find(id);
            db.PROPERTies.Remove(property);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
        public ActionResult ChangePass()
        {
            return View();
        }
        public ActionResult IdentiChangepass(string passOld,string passNew,string passCf)
        {
            USER meo = db.USERs.Find((int)Session["UserID"]);
            if (meo.Password == passOld)
            {
                if (passNew == passCf)
                {
                    meo.Password = passNew;
                    db.SaveChanges();
                    return RedirectToAction("Index", "Home");
                }
                else{
                    ViewBag.error = "Password not confirm";
                    return View();
                }
            }
            else
            {
                ViewBag.error = "Password current not exactly";
                return View();
            }
        }
        public ActionResult ForgetPassword()
        {
            return View();
        }
        public async System.Threading.Tasks.Task<ActionResult> ForgetPass(string Semail,string number_phone)
        {
            if (Semail != "" && number_phone!="") {
                USER meo = db.USERs.ToList().FirstOrDefault(s => s.Email == Semail && s.Phone == number_phone);
                if (meo != null)
                {   
                    string line = "qwertyuiopasdfdghjklzxcvbnm0123456789";
                    int count = line.Length-1;
                  
                    Random number = new Random();   
                    int begin = number.Next(1, count);
                    int end = count - begin;
                    string sum = "";
                    for (int i = 0; i < 3; i++)
                    {
                        sum = sum + line.Substring(begin, end);
                    }
                    meo.Password = sum;
                    db.SaveChanges();
                    ViewBag.email = Semail;
                    /////////////////////
                    var body = "<h1>Hi! "+meo.FullName+" </h1";
                    body += "<p>&ensp; Email From: {0} to {1}</p><br/><p>Message:{2}</p>";
                    body += "<p>Very pleased to hear from customers<p>";
                    body += "<p>JudasFate<p>";
                    var message = new MailMessage();
                    message.To.Add(new MailAddress(Semail));  // replace with valid value 
                    message.From = new MailAddress("k21t1boconganh@gmail.com");
                    message.Subject = "Your email subject";
                    message.Body = string.Format(body,"k21t1boconganh@gmail.com",Semail,"This is your password: "+sum);
                    message.IsBodyHtml = true;

                    using (var smtp = new SmtpClient())
                    {   
                    
                        smtp.Send(message);
                        return RedirectToAction("ForgetComplete", "Agency");
                    }
                }
                else
                {
                    return View("ForgetPassword");
                }
            }
            else
            {
                ViewBag.erorr = "Password or NumberPhone not found";
                return View("ForgetPassword");
            }
        }
        public ActionResult ForgetComplete()
        {
            return View();
        }
    }
}
