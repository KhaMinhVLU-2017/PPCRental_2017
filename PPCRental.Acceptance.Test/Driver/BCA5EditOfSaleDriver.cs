using System;
using System.Collections.Generic;
using System.Linq;
using PPCRental.Controllers;
using TechTalk.SpecFlow;
using PPCRental.Models;
using System.Web.Mvc;
using System.Web.Routing;
using PPCRental.Acceptance.Test.Support;

namespace PPCRental.Acceptance.Test.Driver
{
    public class BCA5EditOfSaleDriver
    {
        public ActionResult _result;

        public void InsertProject(Table project)
        {

            PPCRentalEntities db = new PPCRentalEntities();
            foreach (var item in project.Rows)
            {
                PROPERTY meo = new PROPERTY();
                meo.PropertyName = item["PropertyName"];
                meo.Avatar = item["Avatar"];
                meo.Images = item["Images"];
                meo.Content = item["Content"];
                string statusName = item["Status_Name"];
                int status = db.PROJECT_STATUS.FirstOrDefault(s => s.Status_Name.Equals(statusName)).ID;
                meo.Status_ID = status;
                string userid = item["UserID"];
                meo.UserID = int.Parse(userid); // becase LINQ don't understand string.System
                string duong = item["Duong"];
                string phuong = item["Phuong"];
                string quan = item["Quan"];
                string LoaiDuAn = item["Loạiduan"];
                meo.Street_ID = db.STREETs.FirstOrDefault(s => s.StreetName == duong).ID;
                meo.Ward_ID = db.WARDs.FirstOrDefault(s => s.WardName == phuong).ID;
                meo.District_ID = db.DISTRICTs.FirstOrDefault(s => s.DistrictName == quan).ID;
                meo.UnitPrice = item["TienTe"];
                meo.Price = int.Parse(item["Gia"]);
                meo.BedRoom = int.Parse(item["Phongngu"]);
                meo.BathRoom = int.Parse(item["Phongtam"]);
                db.PROPERTies.Add(meo);
            }
            db.SaveChanges();
        }

        public void ShowProjectScreen(Table project)
        {
   
            //Actual
            var actualProject = _result.Model<PROPERTY>();
            //Compare
            actualProject.PropertyName.Equals(project.Rows[0]["PropertyName"]);
            
        }

        public void EditProjectWithName(string nameProject)
        {
            PPCRentalEntities db = new PPCRentalEntities();
            PROPERTY meo = new PROPERTY();
            meo = db.PROPERTies.FirstOrDefault(s => s.PropertyName.Equals(nameProject));
            meo.PropertyName = " JudasFate Căn hộ Enterprise City";
            var controller = new SaleController();
            _result = controller.Edit(meo.ID);
      
        }

        public void LoginSaleWithAccount(string userS, string pass)
        {
            RouteData routeData = new RouteData();
            routeData.Values.Add("action", "Index");
            routeData.Values.Add("controller", "Sale");

            var Accountcontroller = getAccountControllerMeo(routeData);
            PPCRentalEntities db = new PPCRentalEntities();
            USER meo = new USER();
            meo = db.USERs.FirstOrDefault(s => s.Email==userS && s.Password==pass);
            _result = Accountcontroller.Login(meo,"");

            if (((RedirectToRouteResult)_result).RouteValues["action"].Equals("Index"))
            {
                var Salecontroller = getSaleController();
                _result = Salecontroller.Index();

                var showProperty = _result.Model<IEnumerable<PROPERTY>>();
                ScenarioContext.Current.Add("SalesProperty", showProperty);
            }
        }
        public static AccountController getAccountControllerMeo(RouteData routeData)
        {
            var controller = new AccountController();
            HttpContextStub.SetupController(controller, routeData);
            return controller;
        }
        public static SaleController getSaleController()
        {
            var controller = new SaleController();
            HttpContextStub.SetupController(controller);
            return controller;
        }

        public void Navigator()
        {
            var controller = new HomeController();
            _result = controller.Index();
        }
    }
}
