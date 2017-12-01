﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using PPCRental.Models;
using PagedList;

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
        public ActionResult Create([Bind(Include="ID,PropertyName,Avatar,Images,PropertyType_ID,Content,Street_ID,Ward_ID,District_ID,Price,UnitPrice,Area,BedRoom,BathRoom,PackingPlace,UserID,Created_at,Create_post,Status_ID,Note,Updated_at,Sale_ID")] PROPERTY property)
        {
            if (ModelState.IsValid)
            {
                db.PROPERTies.Add(property);
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
    }
}
