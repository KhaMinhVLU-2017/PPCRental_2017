using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace PPCRental.UITests.Selenium.Driver
{
    public class BCA1DetailSelenium
    {
        public void GotoHomePage(Table project)
        {
            IWebDriver meo = new ChromeDriver();
            meo.Navigate().GoToUrl("zing.vn");
        }
    }
}
