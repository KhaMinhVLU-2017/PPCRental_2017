using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using PPCRental.AcceptanceTests.Drivers;
using PPCRental.AcceptanceTests.Drivers.Property;

namespace PPCRental.Appceptance.Test.StepDifinition
{
    public class EditAgencyProject
    {
        private readonly EditAgencyProject _editagencyproject;
        private readonly PropertyDriver _propertyDriver;

        public EditAgencyProject(Table editproject)
        {
            _propertyDriver.InsertPropertyToDB(editproject);
        }

        [Given(@"The following projects")]
        public void GivenTheFollowingProjects(Table inputProject)
        {
            
        }

        [Given(@"I login into with sale's account")]
        public void GivenILoginIntoWithSaleSAccount(Table table)
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"I edit the project with name '(.*)'")]
        public void WhenIEditTheProjectWithName(string p0)
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"The project details should show")]
        public void ThenTheProjectDetailsShouldShow(Table table)
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"I will edit the information I want to edit and press edit button")]
        public void ThenIWillEditTheInformationIWantToEditAndPressEditButton()
        {
            ScenarioContext.Current.Pending();
        }

    }
}
