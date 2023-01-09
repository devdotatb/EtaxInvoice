using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EtaxInvoice
{
    public class ConfigHelper
    {
        public static string GetAppSetting(string key)
        {
            return System.Configuration.ConfigurationSettings.AppSettings[key];
        }

        public static string ConnectionString
        {
            get
            {
                return GetAppSetting("ConnectionString");
            }
        }
    }
}
