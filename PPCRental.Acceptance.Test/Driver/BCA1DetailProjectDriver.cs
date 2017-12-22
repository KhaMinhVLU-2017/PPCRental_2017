using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using PPCRental.Models;
using TechTalk.SpecFlow;
using PPCRental.Controllers;
using PPCRental.Acceptance.Test.Support;
using FluentAssertions;

namespace PPCRental.Acceptance.Test.Driver
{
    public class BCA1DetailProjectDriver
    {
        public ActionResult _result;
        public void InsertProject(Table Project)
        {
            using (var meo = new PPCRentalEntities())
            {
                foreach (var item in Project.Rows)
                {
                    PROPERTY su = new PROPERTY();
                    su.PropertyName = item["PropertyName"];
                    su.Avatar = item["Avatar"];
                    su.Images = item["Images"];
                    su.Content = item["Content"];
                    int so = meo.PROJECT_STATUS.FirstOrDefault(s => s.Status_Name.Equals("Đã duyệt")).ID;
                    su.Status_ID = so;
                    meo.PROPERTies.Add(su);
                }
                meo.SaveChanges();
            }
        }

        public void ShowDetailProject(Table Project)
        {
            //mongmuon
            var mongmuon = Project.Rows.SingleOrDefault();
            //ketqua
            var actual = _result.Model<PROPERTY>();

            actual.Should().Match<PROPERTY>(
                b => b.PropertyName == mongmuon["PropertyName"]
                && b.Avatar == mongmuon["Avatar"]
                && b.Content == mongmuon["Content"]);

        }

        public void ClickOneProject(string NameProject)
        {
            PPCRentalEntities db = new PPCRentalEntities();
            var meocontroller = new HomeController();
            PROPERTY meo = db.PROPERTies.FirstOrDefault(s => s.PropertyName == NameProject);
            _result = meocontroller.Detail(meo.ID);
        }
    }
}
