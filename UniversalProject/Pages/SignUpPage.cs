

using System;
using OpenQA.Selenium;
using UniversalProject.RandamDataGenerator;

namespace UniversalProject.Pages
{
    public class SignUpPage
    {
        private IWebDriver driver;
        private IWebElement username;
        private IWebElement email;
        private IWebElement password;
        private By userfield = By.XPath("//input[@type='text']");
        private By emailfield = By.XPath("//input[@type='email']");
        private By passwordfield = By.XPath("//input[@type='password']");
        private By signupfield = By.XPath("//button[@type='submit']");
        private string domain = "@hotmail.com";

        public SignUpPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public SignUpPage EnterUserName()
        {
            try
            {
                username = driver.FindElement(userfield);
                username.SendKeys(RandomDataGenerator.GetAlphaRandomData(8));
            }catch (NoSuchElementException)
            {
                Console.WriteLine("The username field cannot be located");
            }
             return this;
        }

        public SignUpPage EnterEmail() { 
        
            try
            {
                email = driver.FindElement(emailfield);
                email.SendKeys(String.Format(RandomDataGenerator.GetAlphaRandomData(5) + "{0}", domain));

            }catch(NoSuchElementException)
            {
                Console.WriteLine("The email field cannot be located");
            }
            return this;
        }

        public SignUpPage EnterPassword()
        {
            try
            {
                password = driver.FindElement(passwordfield);
                password.SendKeys(RandomDataGenerator.GetAlphaRandomData(8));
            }catch(NoSuchElementException)
            {

                Console.WriteLine("The signup field cannot be located");
            }
            return this;
        }

        public UserHomePage SignUp()
        {
            try
            {
                IWebElement signup = driver.FindElement(signupfield);
                signup.Click();

            }
            catch (NoSuchElementException)
            {
                Console.WriteLine("The sign up button cannot be located");
            }
            return new UserHomePage(driver);

        }
        public string GetEnteredUserName()
        {
            username = driver.FindElement(userfield);

            return username.GetAttribute("value").ToString();


        }

       

    }
}

