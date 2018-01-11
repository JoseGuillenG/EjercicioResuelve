using CustomerInvoicesData;
using CustomerInvoicesModels.Request;
using CustomerInvoicesModels.Response;
using System;

namespace CustomerInvoicesLogic
{
    /// <summary>
    /// Clase que contiene lógica para buscar facturas
    /// </summary>
    public class PerDayLogic : IIvoicingCountLogic
    {
        /// <summary>
        /// Método que contiene el algoritmo de búsqueda por día, divide por días el rango de fechas especificado y busca por cada día
        /// </summary>
        /// <param name="request">Objeto request que contiene la información del cliente y fechas de búsqueda</param>
        /// <returns>Objeto response con la información del número de facturas y el número de peticiones</returns>
        public InvoiceCountResponse GetCustomerInvoicesCount(InvoiceCountRequest request)
        {
            var resuelveData = new ResuelveData();
            var result = new InvoiceCountResponse();
            for (var currentDate = request.StartDate; currentDate <= request.EndDate; currentDate = currentDate.AddDays(1))
            {
                var currentRequest = new InvoiceCountRequest(request.CustomerId, currentDate, currentDate);
                var r = resuelveData.GetCustomerInvoicesCount(currentRequest);
                result.AddInvoicesAndCalls(Convert.ToInt32(r),1);
            }

            return result;
        }
    }
}
