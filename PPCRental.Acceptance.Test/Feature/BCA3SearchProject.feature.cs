﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:2.2.0.0
//      SpecFlow Generator Version:2.2.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace PPCRental.Acceptance.Test.Feature
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.2.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [Microsoft.VisualStudio.TestTools.UnitTesting.TestClassAttribute()]
    public partial class BCA3SearchProjectFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
        private Microsoft.VisualStudio.TestTools.UnitTesting.TestContext _testContext;
        
#line 1 "BCA3SearchProject.feature"
#line hidden
        
        public virtual Microsoft.VisualStudio.TestTools.UnitTesting.TestContext TestContext
        {
            get
            {
                return this._testContext;
            }
            set
            {
                this._testContext = value;
            }
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.ClassInitializeAttribute()]
        public static void FeatureSetup(Microsoft.VisualStudio.TestTools.UnitTesting.TestContext testContext)
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner(null, 0);
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "BCA3SearchProject", "\tAllow All people Search Project follow name", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.ClassCleanupAttribute()]
        public static void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestInitializeAttribute()]
        public virtual void TestInitialize()
        {
            if (((testRunner.FeatureContext != null) 
                        && (testRunner.FeatureContext.FeatureInfo.Title != "BCA3SearchProject")))
            {
                global::PPCRental.Acceptance.Test.Feature.BCA3SearchProjectFeature.FeatureSetup(null);
            }
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCleanupAttribute()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<Microsoft.VisualStudio.TestTools.UnitTesting.TestContext>(TestContext);
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        public virtual void FeatureBackground()
        {
#line 3
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "PropertyName",
                        "Avatar",
                        "Images",
                        "Content",
                        "Status_Name"});
            table1.AddRow(new string[] {
                        "Căn hộ Enterprise City",
                        "Sunrise01.JPG",
                        "Sunrise02.JPG",
                        "Nhà đẹp khu dân cư yên tĩnh, có nhiều tiện ích, gần trung tâm quận 7, gần các tru" +
                            "ng tâm thương mại khu vui chơi giải trí như Vivo City, Crescent Mall, Lotte Mart" +
                            ".",
                        "Đã duyệt"});
            table1.AddRow(new string[] {
                        "PIS Top Apartment",
                        "Sunrise01.JPG",
                        "Sunrise02.JPG",
                        "Nhà đẹp khu dân cư yên tĩnh, có nhiều tiện ích, gần trung tâm quận 7, gần các tru" +
                            "ng tâm thương mại khu vui chơi giải trí như Vivo City, Crescent Mall, Lotte Mart" +
                            ".",
                        "Đã duyệt"});
            table1.AddRow(new string[] {
                        "Bigroom with Riverview",
                        "Sunrise01.JPG",
                        "Sunrise02.JPG",
                        "Nhà đẹp khu dân cư yên tĩnh, có nhiều tiện ích, gần trung tâm quận 7, gần các tru" +
                            "ng tâm thương mại khu vui chơi giải trí như Vivo City, Crescent Mall, Lotte Mart" +
                            ".",
                        "Đã duyệt"});
            table1.AddRow(new string[] {
                        "Phú Mỹ Hưng Quận 7",
                        "Sunrise01.JPG",
                        "Sunrise02.JPG",
                        "Nhà đẹp khu dân cư yên tĩnh, có nhiều tiện ích, gần trung tâm quận 7, gần các tru" +
                            "ng tâm thương mại khu vui chơi giải trí như Vivo City, Crescent Mall, Lotte Mart" +
                            ".",
                        "Đã duyệt"});
            table1.AddRow(new string[] {
                        "Scala Quận 9",
                        "Sunrise01.JPG",
                        "Sunrise02.JPG",
                        "Nhà đẹp khu dân cư yên tĩnh, có nhiều tiện ích, gần trung tâm quận 7, gần các tru" +
                            "ng tâm thương mại khu vui chơi giải trí như Vivo City, Crescent Mall, Lotte Mart" +
                            ".",
                        "Đã duyệt"});
            table1.AddRow(new string[] {
                        "Căn hộ Enterprise City 25",
                        "Sunrise01.JPG",
                        "Sunrise02.JPG",
                        "Nhà đẹp khu dân cư yên tĩnh, có nhiều tiện ích, gần trung tâm quận 7, gần các tru" +
                            "ng tâm thương mại khu vui chơi giải trí như Vivo City, Crescent Mall, Lotte Mart" +
                            ".",
                        "Đã duyệt"});
#line 4
testRunner.Given("I have data of Project", ((string)(null)), table1, "Given ");
#line hidden
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Search Project follow Name for All User")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "BCA3SearchProject")]
        public virtual void SearchProjectFollowNameForAllUser()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Search Project follow Name for All User", ((string[])(null)));
#line 14
this.ScenarioSetup(scenarioInfo);
#line 3
this.FeatureBackground();
#line 15
 testRunner.Given("I have a Home Page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 16
 testRunner.When("I click search follow name is \'Scala Quận 9\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "PropertyName",
                        "Avatar",
                        "Images",
                        "Content",
                        "Status_Name"});
            table2.AddRow(new string[] {
                        "Scala Quận 9",
                        "Sunrise01.JPG",
                        "Sunrise02.JPG",
                        "Nhà đẹp khu dân cư yên tĩnh, có nhiều tiện ích, gần trung tâm quận 7, gần các tru" +
                            "ng tâm thương mại khu vui chơi giải trí như Vivo City, Crescent Mall, Lotte Mart" +
                            ".",
                        "Đã duyệt"});
#line 17
 testRunner.Then("I see Project on screen", ((string)(null)), table2, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
