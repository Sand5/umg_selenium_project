

using System;
using OpenQA.Selenium;
using UniversalProject.ObjectRepositories;

namespace UniversalProject.Pages
{
    public class LandingPage
    {
        private readonly IWebDriver driver;
        private By signup = By.LinkText("Sign up");
            
         
        //Constructor to pass in the WebDriver object to the class
        public LandingPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        //The NavigateToSite method is used to go to the entry point of the application
        public void NavigateToSite() {
        
            try
            {
             driver.Navigate().GoToUrl(ObjectRepository.ConfigurationManager.GetEnvironment());
            }catch(WebDriverException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public SignUpPage NavigateToSignUpForm()
        {
            driver.FindElement(signup).Click();

            return new SignUpPage(driver);
        }
    }
}
