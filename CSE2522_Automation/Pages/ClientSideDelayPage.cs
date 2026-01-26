using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace CSE2522_Automation.Pages
{
    public class ClientSideDelayPage
    {
        private IWebDriver driver;

        public ClientSideDelayPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        private By link = By.LinkText("Client Side Delay");
        private By button = By.Id("ajaxButton");
        private By successBanner = By.ClassName("bg-success");

        public void Open()
        {
            driver.FindElement(link).Click();
        }

        public void ClickAndWaitForResult()
        {
            driver.FindElement(button).Click();

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(15));
            wait.Until(d => d.FindElement(successBanner).Displayed);
        }

        public bool IsResultDisplayed()
        {
            return driver.FindElement(successBanner).Displayed;
        }
    }
}
