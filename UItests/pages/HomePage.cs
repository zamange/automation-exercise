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
        // private By signUpButton = By.CssSelector("#header > div > div > div > div.col-sm-8 > div > ul > li:nth-child(4) > a");


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

        

        // public void ClickSignUp()
        // {
            
        // }

    }
}
