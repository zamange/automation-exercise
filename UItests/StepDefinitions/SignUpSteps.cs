using OpenQA.Selenium;
using TechTalk.SpecFlow;
using Utilities;
using pages;

namespace StepDefinitions
{
    [Binding]
    public class SignUpSteps
    {
        private IWebDriver driver;
        private HomePage homePage;

        public SignUpSteps()
        {
            driver = DriverFactory.ReturnDriver();
            homePage = new HomePage(driver);
        }

        [When("I click the signup/login button")]
        public void LoginSgnUpButtonClick()
        {
            homePage.ClickSignUp();
        }

        

        
    }
}
