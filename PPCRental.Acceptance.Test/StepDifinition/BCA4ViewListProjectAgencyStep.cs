using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using PPCRental.Acceptance.Test.Driver;

namespace PPCRental.Acceptance.Test.StepDifinition
{
    [Binding]
    public sealed class BCA4ViewListProjectAgencyStep
    {
        public readonly BCA4ViewListProjectAgencyDriver _driver = new BCA4ViewListProjectAgencyDriver();

        [Given(@"All project posted of Agency")]
        public void GivenAllProjectPostedOfAgency(Table Project)
        {
            _driver.InsertProjectfromUser(Project);
        }

        [Given(@"Agency have a HomePage")]
        public void GivenAgencyHaveAHomePage()
        {
            _driver.NavigatorHomePage();
        }

        [When(@"Agency go to Login with username '(.*)' and pass '(.*)'")]
        public void WhenAgencyGoToLoginWithUsernameAndPass(string User, string Pass)
        {
            _driver.GoPageLoginWithAccount(User, Pass);
        }

        [Then(@"All project of Agency show screen")]
        public void ThenAllProjectOfAgencyShowScreen(Table Project)
        {
            _driver.ShowProjectOfAgency(Project);
        }
    
    }
}
