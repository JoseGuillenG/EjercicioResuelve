using CustomerInvoicesData;
using CustomerInvoicesModels.Request;
using CustomerInvoicesModels.Response;
using System;

namespace CustomerInvoicesLogic
{
    public class PerDayLogic : IIvoicingCountLogic
    {
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
