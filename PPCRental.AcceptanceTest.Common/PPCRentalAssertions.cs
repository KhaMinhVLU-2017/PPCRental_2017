using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PPCRental.Models;
using FluentAssertion;

namespace PPCRental.AcceptanceTest.Common
{
    public class PPCRentalAssertions
    {
        public static void HomeScreenShouldShow(IEnumerable<USER> showViewListProject, string expectedEmail)
        {
            showViewListProject.Select(b => b.Email).Should().Contain(expectedEmail);
        }
        public static void HomeScreenShouldShow(IEnumerable<USER> showViewListProject, IEnumerable<string> expectedEmail)
        {
            showViewListProject.Select(b => b.Email).Should().BeEquivalentTo(expectedEmail);
        }
        public static void FoundPropertyShouldMatchTitles(IEnumerable<PROPERTY> foundBooks, IEnumerable<string> expectedTitles)
        {
            foundBooks.Select(b => b.PropertyName).Should().BeEquivalentTo(expectedTitles);
        }

        public static void FoundBooksShouldMatchTitlesInOrder(IEnumerable<PROPERTY> foundBooks, IEnumerable<string> expectedTitles)
        {
            foundBooks.Select(b => b.PropertyName).Should().Equal(expectedTitles);
        }
        public static void HomeScreenShouldShowInOrder(IEnumerable<PROPERTY> shownBooks, IEnumerable<string> expectedTitles)
        {
            shownBooks.Select(b => b.PropertyName).Should().Equal(expectedTitles);
        }

    }
}
