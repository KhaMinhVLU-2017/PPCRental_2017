﻿
using System.Collections.Generic;
using System.Linq;
using TechTalk.SpecFlow;
using PPCRental.Models;
using System.Web.Mvc;
using PPCRental.Controllers;
using PPCRental.Acceptance.Test.Support;
using FluentAssertions;
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
            var mongmuon = project.Rows[0]["PropertyName"];
            //Actual
            var actualProject = _result.Model<IEnumerable<PROPERTY>>();
            //Compare
            foreach(var item in actualProject)
            {
                item.PropertyName.ShouldBeEquivalentTo(mongmuon);
            }

        }

        public void GoPageLoginWithAccount(string user, string pass)
        {
            var controller = new HomeController();
            _result = controller.Login(user,pass);
        }

        public void NavigatorHomePage()
        {
            var controller = new HomeController();
            _result = controller.Index();
        }
    }
}
