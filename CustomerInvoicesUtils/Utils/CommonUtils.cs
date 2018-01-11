using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerInvoicesUtils.Utils
{
    /// <summary>
    /// Clase con utilerías comunes
    /// </summary>
    public class CommonUtils
    {
        /// <summary>
        /// Obtiene un parámetro especificado en el web.config
        /// </summary>
        /// <param name="key">Nombre del parámetro</param>
        /// <returns>Parámetro en forma de key</returns>
        public static string GetAppSetting(string key)
        {
            var result = ConfigurationManager.AppSettings[key].ToString();
            return result;
        }
    }
}
