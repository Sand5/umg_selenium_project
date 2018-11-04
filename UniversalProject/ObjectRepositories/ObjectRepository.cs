using OpenQA.Selenium;
using UniversalProject.Interfaces;
using UniversalProject.Pages;

namespace UniversalProject.ObjectRepositories
{

    public class ObjectRepository
    {
        //Object properties used by various classes in the framework this helps for dependency injection and prevent null pointers
        public static IWebDriver Driver { get; set; }
        public static IConfigurationManager ConfigurationManager { get; set; }
        public static LandingPage LandingPage { get; set; }
        public static SignUpPage  SignUpPage { get; set; }
        public static UserHomePage UserHomePage { get; set; }
        
    }

}