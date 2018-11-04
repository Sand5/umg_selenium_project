using System;
using OpenQA.Selenium;
using UniversalProject.RandamDataGenerator;

namespace UniversalProject.Pages
{
    public class SignUpPage
    {
        private IWebDriver driver;
        private By userfield = By.XPath("//input[@type='text']");
        private By emailfield = By.XPath("//input[@type='email']");
        private By passwordfield = By.XPath("//input[@type='password']");
        private By signupfield = By.XPath("//button[@type='submit']");
        private string domain = "@hotmail.com";

       
        //Constructor to pass in the WebDriver object to the class
        public SignUpPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        //We use this method to enter a random username in the username field
        public SignUpPage EnterUserName()
        {
            try
            {
                IWebElement username = driver.FindElement(userfield);
                username.SendKeys(RandomDataGenerator.GetAlphaRandomData(8));
            }
            catch (NoSuchElementException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("The username field cannot be located");
            }
            return this;
        }

        //We use this method to enter a random email address in the email field
        public SignUpPage EnterEmail()
        {

            try
            {
                IWebElement email = driver.FindElement(emailfield);
                email.SendKeys(String.Format(RandomDataGenerator.GetAlphaRandomData(5) + "{0}", domain));

            }
            catch (NoSuchElementException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("The email field cannot be located");
            }
            return this;
        }

        // The EnterPassword method is used to enter a random password in the password field
        public SignUpPage EnterPassword()
        {
            try
            {
                IWebElement password = driver.FindElement(passwordfield);
                password.SendKeys(RandomDataGenerator.GetAlphaRandomData(8));
            }
            catch (NoSuchElementException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("The signup field cannot be located");
            }
            return this;
        }

        //Signup method is used to click on the signup page in order to confirm the signup
        public UserHomePage SignUp()
        {
            try
            {
                IWebElement signup = driver.FindElement(signupfield);
                signup.Click();

            }
            catch (NoSuchElementException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("The sign up button cannot be located");
            }
            return new UserHomePage(driver);

        }




    }
}

