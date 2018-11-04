using System.Configuration;
using UniversalProject.ApplicationConfigurationKeys;
using UniversalProject.Interfaces;

namespace UniversalProject.ApplicationConfigurationReaders
{
    public class AppConfigurationReader : IConfigurationManager
    {
        //The GetBrowserType returns the browser type defined in the app config file
        public string GetBrowserType()
        {
            return ConfigurationManager.AppSettings.Get(AppConfigurationKeys.Browser);
        }
        //The GetEnvironment method returns the application URL link defined in the app config file
        public string GetEnvironment()
        {
            return ConfigurationManager.AppSettings.Get(AppConfigurationKeys.Website);
        }
    }
}
