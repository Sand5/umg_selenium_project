using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversalProject.Interfaces
{
   public  interface IConfigurationManager
    {

         string GetBrowserType();
          string GetEnvironment();
    }
}
