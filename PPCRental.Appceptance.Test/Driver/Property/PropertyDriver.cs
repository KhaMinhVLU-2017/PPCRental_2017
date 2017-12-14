using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PPCRental.Models;
using TechTalk.SpecFlow;
using PPCRental.Controllers;
using System.Web.Mvc;
using FluentAssertions;

namespace PPCRental.AcceptanceTests.Drivers.Property
{
   public class PropertyDriver
    {
        public void InsertPropertyToDB(Table inputProjects)
        {
            using (var db = new PPCRentalEntities())
            {
                foreach(var row in inputProjects.Rows)
                {
                    var inputproject = new PROPERTY
                    {
                        PropertyName = row["Name Project"],
                        Avatar = row["Avatar"],
                        Price = int.Parse(row["Price"]),
                        Area = row["Area"],
                        Created_at = Convert.ToDateTime(row["Date create"]),
                        Note = row["Note"],
                        Create_post = Convert.ToDateTime(row["Date update"]),
                        UserID = int.Parse(row["Email"]),
                        Status_ID = int.Parse(row["Status"])                      
                    };
                    db.PROPERTies.Add(inputproject);
                }
                db.SaveChanges();
            }
        }
      
    }

    internal class inputProject
    {
    }
}
