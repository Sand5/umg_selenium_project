namespace UniversalProject.Interfaces
{
   //Interface methods used by the application configuration reader class.
    public interface IConfigurationManager
    {
          string GetBrowserType();
          string GetEnvironment();
    }
}
