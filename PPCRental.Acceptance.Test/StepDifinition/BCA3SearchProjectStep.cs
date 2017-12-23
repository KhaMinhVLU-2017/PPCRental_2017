using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PPCRental.Acceptance.Test.Driver;
using TechTalk.SpecFlow;

namespace PPCRental.Acceptance.Test.StepDifinition
{
    [Binding]
    public sealed class BCA3SearchProjectStep
    {
        public readonly BCA3SearchProjectDriver _driver = new BCA3SearchProjectDriver();

        [Given(@"I have data of Project")]
        public void GivenIHaveDataOfProject(Table Project)
        {
            _driver.InsertProject(Project);
        }

        [Given(@"I have a Home Page")]
        public void GivenIHaveAHomePage()
        {
            _driver.Navigator();
        }

        [When(@"I click search follow name is '(.*)'")]
        public void WhenIClickSearchFollowNameIs(string NameProject)
        {
            _driver.SearchNameProject(NameProject.Trim());
        }

        [Then(@"I see Project on screen")]
        public void ThenISeeProjectOnScreen(Table Project)
        {
            _driver.ShowProject(Project);
        }

    }
}
