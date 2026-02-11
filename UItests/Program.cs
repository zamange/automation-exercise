using OpenQA.Selenium;
using Utilities;
using pages; 


class Program
{
    static void Main()
    {

        IWebDriver driver = DriverFactory.ReturnDriver();

        HomePage homePage = new HomePage(driver);


        homePage.GoToUrl();
        homePage.ClickSignUp();


        driver.Quit();
    }
}
