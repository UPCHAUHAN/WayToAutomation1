using System;
using System.Configuration;
using WayToAutomation.Settings;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace WayToAutomation.Configuration
{
    public class AppConfigReader
    {
        public static string getBrowser = ConfigurationManager.AppSettings["Browser"];
        public static string getpasswor = ConfigurationManager.AppSettings["Password"];
        public static string userName = ConfigurationManager.AppSettings["UserName"];
        public static string url = ConfigurationManager.AppSettings["Website"];
    }
}
