using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerInvoicesModels.Response
{
    /// <summary>
    /// Objeto de tipo response para el conteo de facturas de un cliente
    /// </summary>
    public class InvoiceCountResponse
    {
        /// <summary>
        /// Cantidad de facturas de un cliente
        /// </summary>
        public int CustomerInvoices { get; set; }

        /// <summary>
        /// Número de llamadas
        /// </summary>
        public int Calls { get; set; }

        /// <summary>
        /// Constructor de la clase 
        /// </summary>
        public InvoiceCountResponse()
        {
            this.CustomerInvoices = 0;
            this.Calls = 0;
        }

        /// <summary>
        /// Método para sumar número de facturas y llamadas
        /// </summary>
        /// <param name="customerInvoices">Número de facturas</param>
        /// <param name="calls">Número de llamadas</param>
        public void AddInvoicesAndCalls(int customerInvoices, int calls)
        {
            this.CustomerInvoices += customerInvoices;
            this.Calls += calls;
        }
    }
}
