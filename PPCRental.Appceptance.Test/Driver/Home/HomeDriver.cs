using System.Collections.Generic;
using System.Linq;
using PPCRental.Controllers;
using System.Web.Mvc;
using TechTalk.SpecFlow;
using PPCRental.Models;
//using PPCRental.AcceptanceTests.Common;

namespace PPCRental.AcceptanceTests.Drivers.Home
{
    public class HomeDriver
    {
        private ActionResult _result;

        public void NavigateInterface()
        {
            using (var controller = new HomeController())
            {
                _result = controller.Index();
            }
        }

      
        public void ShowViewListProject(Table expectedShowViewListProject)
        => ShowViewListProject(expectedShowViewListProject.Rows.Select(r=>r["Email"]));

        public void ShowViewListProject(IEnumerable<string> expectedEmails)
        {
            var showViewListProject = _result.Model<IEnumerable<USER>>();

            PPCRentalAssertions.HomeScreenShouldShow(showViewListProject, expectedEmail);
        }
    }
}
