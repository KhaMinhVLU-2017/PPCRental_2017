using PPCRental;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechTalk.SpecFlow;

namespace PPCRental.AcceptanceTests.StepDifinition
{
    [Binding]
    public sealed class DetailProjectStep
    {
        public Driver.DetailProjectDriver _driver;


        [Given(@"I have home page of Projejct")]
        public void GivenIHaveHomePageOfProjejct(Table Project)
        {
            _driver.InsertProjectToDB(Project);
        }

        [When(@"User click '(.*)' one any of project")]
        public void WhenUserClickOneAnyOfProject(string IdProject)
        {
            _driver.getProject(IdProject);
        }

        [Then(@"Show Detail Project")]
        public void ThenShowDetailProject(Table ShowDetail)
        {
            _driver.ShowPropertyDetail(ShowDetail);
        }

    }
}
