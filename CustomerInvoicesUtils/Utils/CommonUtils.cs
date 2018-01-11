using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerInvoicesUtils.Utils
{
    public class CommonUtils
    {
        public static string GetAppSetting(string key)
        {
            var result = ConfigurationManager.AppSettings[key].ToString();
            return result;
        }
    }
}
