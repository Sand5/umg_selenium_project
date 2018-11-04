using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.IO;
using System.Reflection;


namespace UniversalProject.DriverManager
{
    public abstract class DriverTypeManager
    {
        //The GetChromeDriver method is used to create a new chrome driver as the browser to use
        public static IWebDriver GetChromeDriver()
        {
            return new ChromeDriver(GetExcutable());
        }
        
        //The GetExcutable method returns the location of the chromedriver.
        private static string GetExcutable()
        {
            return Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
        }
    }
}
