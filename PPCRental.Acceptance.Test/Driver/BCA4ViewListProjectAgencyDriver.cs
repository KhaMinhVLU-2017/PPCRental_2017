
using System.Collections.Generic;
using System.Linq;
using TechTalk.SpecFlow;
using PPCRental.Models;
using System.Web.Mvc;
using PPCRental.Controllers;
using PPCRental.Acceptance.Test.Support;
using FluentAssertions;
using System.Web.Routing;

namespace PPCRental.Acceptance.Test.Driver
{
    public class BCA4ViewListProjectAgencyDriver
    {
        public ActionResult _result;

        public void InsertProjectfromUser(Table project)
        {
            PPCRentalEntities db = new PPCRentalEntities();
            foreach(var item in project.Rows)
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
                db.PROPERTies.Add(meo);
            }
            db.SaveChanges();
        }


        public void ShowProjectOfAgency(Table project)
        {
            //Project Expected
    
            //Actual
            var actualProject = _result.Model<IEnumerable<PROPERTY>>();
            //Compare
    
            int count = 0;
            
            foreach(var item in actualProject)
            {
                item.PropertyName.Equals(project.Rows[count]["PropertyName"]);
                count++;
            }

        }

        public void Login(string user, string pass)
        {
            RouteData routeData = new RouteData();
            routeData.Values.Add("action", "Index");
            routeData.Values.Add("controller", "Agency");

            var homecontroller = getHomeControllerMeo(routeData);
            _result = homecontroller.Login(user, pass);

            if (((RedirectToRouteResult)_result).RouteValues["action"].Equals("Index"))
            {
                var agencycontroller = getAgencyController();
                _result = agencycontroller.Index();

                var showProperty = _result.Model<IEnumerable<PROPERTY>>();
                ScenarioContext.Current.Add("AgencyProperty", showProperty);
            }
        }

        public void NavigatorHomePage()
        {
            var controller = new HomeController();
            _result = controller.Index();
        }

        public static HomeController getHomeControllerMeo(RouteData routeData)
        {
            var controller = new HomeController();
            HttpContextStub.SetupController(controller, routeData);
            return controller;
        }
        public static AgencyController getAgencyController()
        {
            var controller = new AgencyController();
            HttpContextStub.SetupController(controller);
            return controller;
        }
    }
}   
