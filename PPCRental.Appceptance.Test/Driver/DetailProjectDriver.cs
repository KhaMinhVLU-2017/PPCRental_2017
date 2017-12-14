
using System.Linq;
using TechTalk.SpecFlow;
using PPCRental.Models;
using PPCRental.Controllers;
using System.Web.Mvc;
using PPCRental.Appceptance.Test.Support;
using FluentAssertions;


namespace PPCRental.AcceptanceTests.Driver
{
    public class DetailProjectDriver
    {
        private readonly CatalogContext _context;
        private ActionResult _result;

        public DetailProjectDriver(CatalogContext context)
        {
            _context = context;
        }

        public void InsertProjectToDB(Table project)
        {
            using(var db = new PPCRentalEntities())
            {
                foreach(var item in project.Rows)
                {
                    var PropertyPro = new PROPERTY
                    {
                        PropertyName = item["PropertyName"],
                        Avatar = item["Avatar"],
                        Images = item["Images"],
                        Content = item["Content"],
                        Price = int.Parse(item["Price"]),
                        UnitPrice = item["UnitPrice"],
                        UserID = int.Parse(item["UserID"])
                    };
                    db.PROPERTies.Add(PropertyPro);
                }
                db.SaveChanges();
            }
        }

        public void ShowPropertyDetail(Table showDetail)
        {
            var ProjectDetails = showDetail.Rows.Single();

            var actualProjectDetails = _result.Model<PROPERTY>();

            actualProjectDetails.Should().Match<PROPERTY>(
              b => b.PropertyName == ProjectDetails["PropertyName"]
              && b.Content == ProjectDetails["Content"]
              && b.Price == decimal.Parse(ProjectDetails["Price"]));
        }

        public void getProject(string idProject)
        {
            var Property = _context.ReferenceProperty.GetById(idProject);
            using (var _controller = new HomeController())
            {
                _result = _controller.Detail(int.Parse(idProject));
            }

        }
    }
}
