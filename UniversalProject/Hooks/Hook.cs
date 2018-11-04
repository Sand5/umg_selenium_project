using System;
using TechTalk.SpecFlow;
using UniversalProject.ApplicationConfigurationReaders;
using UniversalProject.DriverManager;
using UniversalProject.ObjectRepositories;


namespace UniversalProject.Hooks
{
    [Binding]
    public abstract class Hook
    {
        [BeforeScenario]
        //InitializeBrowser method is used to create and launch the instance of the chosen browser
        public static void InitializeBrowserType()
        {
            //Point the object repository config property to the application reader class.
            ObjectRepository.ConfigurationManager = new AppConfigurationReader();

            //Use the GetBroswer method to check with broswer to use 
            switch (ObjectRepository.ConfigurationManager.GetBrowserType())
            {
                case "CHROME":

                    ObjectRepository.Driver = DriverTypeManager.GetChromeDriver();
                    break;

                 default: throw new Exception("The Browser that you require is not vaild please check App.config file");

            }

            


        }

        [AfterScenario]
        //ScenarioCleanUp method checks to see if the browser is alive then closes the browser and the instance.
        public static void ScenarioCleanUp()
        {
            if (ObjectRepository.Driver != null)
            {
                ObjectRepository.Driver.Close();
                ObjectRepository.Driver.Quit();


            }
        }

    }
}
