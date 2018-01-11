using System.Web;
using System.Web.Mvc;

namespace CustomerInvoicesWeb
{
    /// <summary>
    /// Clase que controla los filtros
    /// </summary>
    public class FilterConfig
    {
        /// <summary>
        /// Método que registra los filtros globales
        /// </summary>
        /// <param name="filters"></param>
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
