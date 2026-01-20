using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace CSE2522_Automation
{
    public class TestBase
    {
        protected IWebDriver Driver;
        [SetUp]
        public void SetUp()
        {
            Driver = new ChromeDriver();
            Driver.Manage().Window.Maximize();
            Driver.Navigate().GoToUrl("https://uitestingplayground.com/");
        }
        [TearDown]
        public void TearDown()
        {
            Driver.Quit();
        }
    }
}
