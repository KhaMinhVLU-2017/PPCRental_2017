using PPCRental.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using System.Web.Mvc;
using PPCRental.Controllers;
using PPCRental.Acceptance.Test.Support;

namespace PPCRental.Acceptance.Test.Driver
{
    public class BCA3SearchProjectDriver
    {
        public ActionResult _result;

        public void InsertProject(Table project)
        {
            using (var db = new PPCRentalEntities())
            {
                foreach (var item in project.Rows)
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

        public void ShowProject(Table project)
        {

            string NameMongMuon = project.Rows[0]["PropertyName"];


            var NameReadly = _result.Model<IEnumerable<PROPERTY>>();

           
            foreach (var item in NameReadly)
            {
                item.PropertyName.Equals(NameMongMuon);
            }
            
        }

        public void SearchNameProject(string nameProject)
        {
             var controller = new HomeController();
            _result = controller.Search(nameProject);
        }

        public void Navigator()
        {
            var controller = new HomeController();
            _result = controller.Index();
        }
    }
}
