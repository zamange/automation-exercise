using OpenQA.Selenium;
using TechTalk.SpecFlow;
using Utilities;
using pages;

namespace StepDefinitions
{
    [Binding]
    public class HomePageSteps
    {
        private IWebDriver driver;
        private HomePage homePage;

        public HomePageSteps()
        {
            driver = DriverFactory.ReturnDriver();
            homePage = new HomePage(driver);
        }

        [Given("I launch the browser")]
        public void LaunchBrowser()
        {
            homePage.GoToUrl();
        }

        [Then("I should see the home page")]
        public void SeeHomePage()
        {
            homePage.VerifyHomeIcon();
        }

        [When("I click the signup/login button")]
        public void LoginSgnUpButtonClick()
        {
            homePage.ClickSignUp();
        }

        
    }
}
