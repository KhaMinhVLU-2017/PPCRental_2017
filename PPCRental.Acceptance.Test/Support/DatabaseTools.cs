using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using PPCRental.Models;

namespace PPCRental.Acceptance.Test.Support
{
    [Binding]
    public class DatabaseTools
    {
       [BeforeScenario]
        public void CleanData()
        {
            using (var db = new PPCRentalEntities())
            {
                db.PROPERTies.RemoveRange(db.PROPERTies);
                db.SaveChanges();
            }
        }
    }
}
