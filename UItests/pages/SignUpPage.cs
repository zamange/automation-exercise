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

        private By userName = By.Id("#name");

        private By userEmail = By.Id("#email");
        private By userPassword = By.Id("#password");
        // private By userDateOfBirth = By.Id("//*[@id="days"]");
        private By userDayOfBirth = By.Id("days");
        private By userMonthOfBirth = By.Id("months");
        private By userYearOfBirth = By.Id("years");
        private By newsLetterCheck = By.Id("");
        private By offersCheck = By.Id("");
        private By firstName = By.Id("");
        private By lastName = By.Id("");
        private By company = By.Id("");
        private By address = By.Id("");
        private By address2 = By.Id("");
        private By country = By.Id("");
        private By state = By.Id("");
        private By city = By.Id("");
        private By zipCode = By.Id("");
        
        
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