using CustomerInvoicesData;
using CustomerInvoicesModels.Request;
using CustomerInvoicesModels.Response;
using System;

namespace CustomerInvoicesLogic
{
    /// <summary>
    /// Clase que contiene lógica para buscar facturas
    /// </summary>
    public class HalfLogic : IIvoicingCountLogic
    {
        /// <summary>
        /// Método que contiene el algortmo de búsqueda por la mitad, divide a la mitad la búsqueda si esta arrojó más de 100 resultadoos
        /// </summary>
        /// <param name="request">Objeto request que contiene la información del cliente y fechas de búsqueda</param>
        /// <returns>Objeto response con la información del número de facturas y el número de peticiones</returns>
        public InvoiceCountResponse GetCustomerInvoicesCount(InvoiceCountRequest request)
        {
            var invoicesCount = 0;
            var resuelveData = new ResuelveData();
            var result = new InvoiceCountResponse();

            var currentRequest = new InvoiceCountRequest(request.CustomerId, request.StartDate, request.EndDate);
            var r = resuelveData.GetCustomerInvoicesCount(currentRequest);

            if (int.TryParse(r, out invoicesCount))
            {
                result.AddInvoicesAndCalls(Convert.ToInt32(r), 1);
                return result;
            }
            else
            {
                // Se obtiene la cantidad de días y se divide a la mitad
                var halfOfDays = (int)((request.EndDate - request.StartDate).TotalDays / 2);

                var requestLeft = new InvoiceCountRequest(request.CustomerId, request.StartDate, request.StartDate.AddDays(halfOfDays));
                var requestRight = new InvoiceCountRequest(request.CustomerId, request.StartDate.AddDays(halfOfDays + 1), request.EndDate);

                var resultLeft = GetCustomerInvoicesCount(requestLeft);
                var resultRigth = GetCustomerInvoicesCount(requestRight);

                result.AddInvoicesAndCalls(resultLeft.CustomerInvoices, resultLeft.Calls + 1);
                result.AddInvoicesAndCalls(resultRigth.CustomerInvoices, resultRigth.Calls);

                return result;
            }
        }
    }
}
