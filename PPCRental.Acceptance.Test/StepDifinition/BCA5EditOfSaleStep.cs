using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using PPCRental.Acceptance.Test.Driver;

namespace PPCRental.Acceptance.Test.StepDifinition
{
    [Binding]
    public sealed class BCA5EditOfSaleStep
    {
        public readonly BCA5EditOfSaleDriver _driver = new BCA5EditOfSaleDriver();

        [Given(@"Data of Projects")]
        public void GivenDataOfProjects(Table Project)
        {
            _driver.InsertProject(Project);
        }

        [Given(@"Sale at a HomePage")]
        public void GivenSaleAtAHomePage()
        {
            _driver.Navigator();
        }

        [When(@"Sale login with account is user:'(.*)' and pass:'(.*)'")]
        public void WhenSaleLoginWithAccountIsUserAndPass(string user, string pass)
        {
            _driver.LoginSaleWithAccount(user, pass);
        }

        [When(@"Sales Edit Project '(.*)'")]
        public void WhenSalesEditProject(string NameProject)
        {
            _driver.EditProjectWithName(NameProject);
        }

        [Then(@"Result screen project")]
        public void ThenResultScreenProject(Table Project)
        {
            _driver.ShowProjectScreen(Project);
        }

    }
}
