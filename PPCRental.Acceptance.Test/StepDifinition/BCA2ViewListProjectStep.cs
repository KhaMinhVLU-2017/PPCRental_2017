using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using PPCRental.Acceptance.Test.Driver;

namespace PPCRental.Acceptance.Test.StepDifinition
{
    [Binding]
    public sealed class BCA2ViewListProjectStep
    {
        public readonly BCA2ViewListProjectDriver _driver = new BCA2ViewListProjectDriver();
         
        [Given(@"I Have Data of Project")]
        public void GivenIHaveDataOfProject(Table Project)
        {
            _driver.InsertProject(Project);
        }

        [When(@"I go to Home Page")]
        public void WhenIGoToHomePage()
        {
            _driver.Navigator();
        }

        [Then(@"I see List Project")]
        public void ThenISeeListProject(Table Project)
        {
            _driver.ShowListProject(Project);
        }


    }
}
