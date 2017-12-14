using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using PPCRental.AcceptanceTests.Drivers.Property;
using PPCRental.AcceptanceTests.Drivers.Home;
namespace PPCRental.AcceptanceTests.StepDefinitions
{
 [Binding]
 public class ViewListProject
 {
        private readonly PropertyDriver _propertyDriver;
        private readonly HomeDriver _homeDriver;
        private readonly object ExpectedViewListProject;

        [Given(@"the following project")]
        public void GivenTheFollowingProject(Table inputProject)
        {
            _propertyDriver.InsertPropertyToDB(inputProject);
        }

        [Given(@"Agency at the login page")]
        public void GivenAgencyAtTheLoginPage()
        {
            _homeDriver.NavigateInterface();
        }

        [When(@"Agency login with '(.*)' and '(.*)'")]
        public void WhenAgencyLoginWithAnd(string Email, string Password)
        {
            _homeDriver.Login(Email, Password);
        }

        [Then(@"Agency should see his own project list")]
        public void ThenAgencyShouldSeeHisOwnProjectList(Table expectedViewListProject)
        {
            _homeDriver.ShowViewListProject(expectedViewListProject);
        }
    }
}
