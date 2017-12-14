using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PPCRental.Models;

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
    }
}
