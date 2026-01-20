//
// this is just a test file to check chrome
//
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace CSE2522_Automation.test
{
    [TestFixture]
    public class SmokeTest
    {
        [Test]
        public void OpenChromeTest()
        {
            var options = new ChromeOptions();
            options.AddArgument("--remote-allow-origins=*");

            IWebDriver driver = new ChromeDriver(options);
            driver.Navigate().GoToUrl("https://google.com");
            driver.Quit();
        }
    }
}
