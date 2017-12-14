using TechTalk.SpecFlow;
using PPCRental.AcceptanceTests.Driver.Search;

namespace PPCRental.Appceptance.Test.StepDifinition
{
    [Binding, Scope(Tag = "automated")]
    public class FilterProjectStep
    {
        private readonly SearchPropertyDriver _searchDriver;

        public FilterProjectStep(SearchPropertyDriver driver)
        {
            _searchDriver = driver;
        }

        [When(@"I search for Property by the phrase '(.*)'")]
        public void WhenISearchForPropertyByThePhrase(string searchText)
        {
            _searchDriver.Search(searchText);
        }

        [Then(@"the list of found Property should contain only: (.*)")]
        public void ThenTheListOfFoundPropertyShouldContainOnly(string expectedTitleList)
        {
            _searchDriver.ShowProject(expectedTitleList);
        }

        [Then(@"the list of found Property should be:")]
        public void ThenTheListOfFoundPropertyShouldBe(Table expectedProperty)
        {
            _searchDriver.ShowProject(expectedProperty);
        }
    }
}

