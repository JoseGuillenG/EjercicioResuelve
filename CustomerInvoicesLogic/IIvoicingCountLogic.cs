using CustomerInvoicesModels.Request;
using CustomerInvoicesModels.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerInvoicesLogic
{
    /// <summary>
    /// Interfaz que controla los diferentes algoritmos de búsqueda
    /// </summary>
    public interface IIvoicingCountLogic
    {
        /// <summary>
        /// Método que contiendrá los algoritmos de búsqueda
        /// </summary>
        /// <param name="request">Objeto request que contiene la información del cliente y fechas de búsqueda</param>
        /// <returns>Objeto response con la información del número de facturas y el número de peticiones</returns>
        InvoiceCountResponse GetCustomerInvoicesCount(InvoiceCountRequest request);
    }
}
