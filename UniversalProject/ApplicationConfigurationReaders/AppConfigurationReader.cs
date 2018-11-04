using System.Configuration;
using UniversalProject.ApplicationConfigurationKeys;
using UniversalProject.Interfaces;

namespace UniversalProject.ApplicationConfigurationReaders
{
    public class AppConfigurationReader : IConfigurationManager
    {
        public string GetBrowserType()
        {
           return ConfigurationManager.AppSettings.Get(AppConfigurationKeys.Browser);
   }

        public string GetEnvironment()
        {
            return ConfigurationManager.AppSettings.Get(AppConfigurationKeys.Website);
        }
    }
}
