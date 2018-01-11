using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerInvoicesModels.Request
{
    /// <summary>
    /// Clase request para solicitar el número de facturas y llamadas
    /// </summary>
    public class InvoiceCountRequest
    {
        /// <summary>
        /// Id del cliente
        /// </summary>
        public string CustomerId { get; set; }

        /// <summary>
        /// Fecha de inicio
        /// </summary>
        public DateTime StartDate { get; set; }

        /// <summary>
        /// Fecha fin
        /// </summary>
        public DateTime EndDate { get; set; }

        /// <summary>
        /// Constructor de la clase
        /// </summary>
        /// <param name="customerId">Id del cliente</param>
        /// <param name="startDate">Fecha de inicio</param>
        /// <param name="endDate">Fecha de fin</param>
        public InvoiceCountRequest(string customerId, DateTime startDate, DateTime endDate)
        {
            this.CustomerId = customerId;
            this.StartDate = startDate;
            this.EndDate = endDate;
        }
    }
}
