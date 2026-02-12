using OpenQA.Selenium;
using Utilities;

namespace pages
{
    public class HomePage
    {
        private IWebDriver driver;
        // IWebDriver driver = DriverFactory.ReturnDriver();
        private By signupButton = By.CssSelector("a[href='/login']");
        private By homePageIcon = By.XPath("//a[contains(text(),'Home')]");


        public HomePage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void GoToUrl()
        {
            driver.Navigate().GoToUrl("http://automationexercise.com");
        }

        public void ClickSignUp()
        {
            driver.FindElement(signupButton).Click();
        }
        public bool VerifyHomeIcon()
        {
            return driver.FindElement(homePageIcon).Displayed;
        }

    }
}
