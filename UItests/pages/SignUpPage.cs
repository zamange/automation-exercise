using OpenQA.Selenium;
using Utilities;
using pages; 

namespace pages
{
    public class SignUpPage
    {
        private IWebDriver driver;
        private By signupLoginButton = By.CssSelector("a[href='/login']");
        private By signUpPage = By.XPath("//a[contains(text(),'Signup')]");
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
        private By newsLetterCheck = By.Id("newsletter");
        private By offersCheck = By.Id("optin");
        private By firstName = By.Id("first_name");
        private By lastName = By.Id("last_name");
        private By company = By.Id("company");
        private By address = By.Id("address1");
        private By address2 = By.Id("address2");
        private By country = By.Id("country");
        private By state = By.Id("state");
        private By city = By.Id("city");
        private By zipCode = By.Id("zipcode");

        private By mobileNumber = By.Id("mobile_number");
        private By createAccount = By.Id("button");
        private By accountCreatedText = By.Id("form");
        private By continueButton = By.XPath("/html/body/section/div/div[1]/div/div/a");
        private By loggedInAs = By.Id("header");
        private By deleteAccount = By.XPath("/html/body/header/div/div/div/div[2]/div/ul/li[5]/a/text()");
        private By accountDeletedText = By.Id("form");
        private By continueDeleteButton = By.CssSelector("a[data-qa='continue-button']");        
        public SignUpPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void ClickSignUpLogin()
        {
            driver.FindElement(signupLoginButton).Click();
        }


        public bool VerifySignUpPage()
        {
            return driver.FindElement(signUpPage).Displayed;
        }

        public bool VerifyNewUserText()
        {
            return driver.FindElement(newUserText).Displayed;
        }

        public void EnterNameAndEmail(string name, string email)
        {
            driver.FindElement(nameInput).SendKeys(name);
            driver.FindElement(emailInput).SendKeys(email);
        }
        public void ClickSignUp()
        {
            driver.FindElement(signUpButton).Click();
        }

        public bool VerifyAccountInfoText()
        {
            return driver.FindElement(accountInfo).Displayed;
        }

        public void PopulateAccountInfo(string title, string name, string email, string password, string day, string month, string year)
        {
            driver.FindElement(nameInput).SendKeys(title);
            driver.FindElement(userName).SendKeys(name);
            driver.FindElement(userEmail).SendKeys(email);
            driver.FindElement(userPassword).SendKeys(password);
            driver.FindElement(nameInput).SendKeys(day);
            driver.FindElement(emailInput).SendKeys(month);
            driver.FindElement(emailInput).SendKeys(year);
        }
        



                
        
    }
}