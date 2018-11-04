using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using UniversalProject.ObjectRepositories;
using ExpectedConditions = SeleniumExtras.WaitHelpers.ExpectedConditions;

namespace UniversalProject.Pages
{
    public class UserHomePage
    {
        private IWebDriver driver;
        private By feed = By.PartialLinkText("Your Feed");
        private By username = By.XPath("//a[@class='nav-link ng-binding']");


        //Constructor to pass in the WebDriver object to the class
        public UserHomePage(IWebDriver driver)
        {
            this.driver = driver;
        }

        //This method is used to returns true of false is the Your Feed Link is displayed once the user is logged in
        public bool YourFeedLinkDisplayed()
        {
            try
            {
                var wait = new WebDriverWait(ObjectRepository.Driver, TimeSpan.FromSeconds(60));
                return wait.Until(ExpectedConditions.ElementIsVisible(feed)).Displayed;

            }
            catch (NoSuchElementException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("The Your Feed link is not displayed");
            }

            return false;

        }

        //The LoggedInUserName method returns true or false if the username is displayed on the page
        public bool LoggedInUsNerNameDisplayed()
        {
            try
            {
                return driver.FindElement(username).Displayed;
            }
            catch (NoSuchElementException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("The logged in username is not displayed");
            }

            return false;
        }

    }
}