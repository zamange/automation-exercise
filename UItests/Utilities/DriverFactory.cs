using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Utilities
{
    public class DriverFactory
    {
        public static IWebDriver ReturnDriver()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            // Thread.Sleep(10000);
            return driver;
        }
    }
}
