using OpenQA.Selenium;
using Utilities;
using pages; 

namespace pages
{
    public class SignUpPage
    {
        private IWebDriver driver;
        private By newUserText = By.XPath("//h2[text()='New User Signup!']");

        private By nameInput = By.Name("name");

        private By emailInput = By.Name("email");

        private By signUpButton = By.CssSelector("button[data-qa='signup-button']");
        private By accountInfo = By.XPath("//b[text()='Enter Account Information']");

        private By titleCheckMr = By.Id("#id_gender1");
        private By titleCheckMrs = By.Id("#id_gender1");
        public SignUpPage(IWebDriver driver)
        {
            this.driver = driver;
        }
        
        

        // public void ClickSignUp()
        // {
        //     driver.FindElement(signupButton).Click();
        // }

        
    }
}