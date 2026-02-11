using OpenQA.Selenium;
using Utilities;

namespace pages
{
    public class HomePage
    {
        private IWebDriver driver;
        // IWebDriver driver = DriverFactory.ReturnDriver();
        private By signupButton = By.CssSelector("a[href='/login']");


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
    }
}
