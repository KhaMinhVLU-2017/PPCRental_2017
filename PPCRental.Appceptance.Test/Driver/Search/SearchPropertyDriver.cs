using System.Collections.Generic;
using System.Linq;
using PPCRental.Controllers;
using PPCRental.AcceptanceTests.Support;
using PPCRental.Models;
using PPCRental.AcceptanceTests.Common;
using TechTalk.SpecFlow;

namespace PPCRental.Appceptance.Test.Driver.Search
{
    public class SearchPropertyDriver
    {
        private readonly SearchResultState _state;

        public SearchPropertyDriver(SearchResultState state)
        {
            _state = state;
        }

        public void Search(string searchTerm)
        {
            var controller = new HomeController();
            _state.ActionResult = controller.Search(searchTerm);
        }

        public void ShowProperty(string expectedTitlesString)
        {
            //Arrange
            var expectedTitles = from t in expectedTitlesString.Split(',')
                                 select t.Trim().Trim('\'');

            //Action
            var ShownProperty = _state.ActionResult.Model<IEnumerable<ListProperty>>();

            //Assert
            PPCRentalAssertions.HomeScreenShouldShow(ShownProperty, expectedTitles);
        }

        public void ShowBooks(Table expectedProperty)
        {
            //Arrange
            var expectedPropertyname= expectedProperty.Rows.Select(r => r["Propertyname"]);

            //Action
            var ShownProperty = _state.ActionResult.Model<IEnumerable<PROPERTY>>();

            //Assert
            PPCRentalAssertion.HomeScreenShouldShowInOrder(ShownBooks, expectedTitles);
        }
    }
}

