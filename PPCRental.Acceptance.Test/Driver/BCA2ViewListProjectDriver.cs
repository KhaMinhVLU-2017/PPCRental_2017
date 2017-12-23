
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using PPCRental.Models;
using PPCRental.Controllers;
using System.Web.Mvc;

namespace PPCRental.Acceptance.Test.Driver
{
    public class BCA2ViewListProjectDriver
    {
        public ActionResult _result;

        public void InsertProject(Table project)
        {
            using ( var db = new PPCRentalEntities())
            {
                foreach(var item in project.Rows)
                {
                    PROPERTY meo = new PROPERTY();
                    meo.PropertyName = item["PropertyName"];
                    meo.Avatar = item["Avatar"];
                    meo.Images = item["Images"];
                    meo.Content = item["Content"];
                    string statusNae = item["Status_Name"];
                    int status = db.PROJECT_STATUS.FirstOrDefault(s => s.Status_Name.Equals(statusNae)).ID;
                    meo.Status_ID = status;
                    db.PROPERTies.Add(meo);
                }
                db.SaveChanges();
            }
        }

        public void ShowListProject(Table project)
        {
            PPCRentalEntities db = new PPCRentalEntities();
            foreach(var item in project.Rows)
            {
                PROPERTY meo = new PROPERTY();
                string nameSta = item["PropertyName"];
                meo = db.PROPERTies.FirstOrDefault(s => s.PropertyName.Equals(nameSta));
                item["PropertyName"].Equals(meo.PropertyName);
            }
        }

        public void Navigator()
        {
            var controller = new HomeController();
            _result = controller.Index();
        }
    }
}
