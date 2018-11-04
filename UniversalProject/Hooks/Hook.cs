
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
         public static void InitializeBrowserType()
        {
            ObjectRepository.ConfigurationManager = new AppConfigurationReader();

            switch (ObjectRepository.ConfigurationManager.GetBrowserType())
            {

                  case "CHROME":

                   ObjectRepository.Driver = DriverTypeManager.GetChromeDriver();
                    break;

                   default: throw new Exception("The Browser that you require is not vaild please check App.config file");


            }

           
        }

        [AfterScenario]
        public static void ScenarioCleanUp()
        {
            if(ObjectRepository.Driver != null)
            {
                ObjectRepository.Driver.Close();
                ObjectRepository.Driver.Quit();


            }
        }

    }
}
