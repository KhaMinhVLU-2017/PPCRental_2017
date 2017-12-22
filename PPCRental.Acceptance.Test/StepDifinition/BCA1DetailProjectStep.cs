
using System.Web.Mvc;
using TechTalk.SpecFlow;
using PPCRental.Acceptance.Test.Driver;
namespace PPCRental.Acceptance.Test.StepDifinition
{
    [Binding]
    public sealed class BCA1DetailProjectStep
    {
        public readonly BCA1DetailProjectDriver _driver = new BCA1DetailProjectDriver();

        [Given(@"I have home page of Projejct")]
        public void GivenIHaveHomePageOfProjejct(Table Project)
        {
            _driver.InsertProject(Project);
        }

        [When(@"User click '(.*)' one any of project")]
        public void WhenUserClickOneAnyOfProject(string NameProject)
        {
            _driver.ClickOneProject(NameProject);
        }

        [Then(@"Show Detail Project")]
        public void ThenShowDetailProject(Table Project)
        {
            _driver.ShowDetailProject(Project);
        }

    }
}
