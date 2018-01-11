using CustomerInvoicesData;
using CustomerInvoicesModels.Request;
using CustomerInvoicesModels.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerInvoicesLogic
{
    public class PerDayLogic
    {
        public static InvoiceCountResponse GetCustomerInvoicesCount(InvoiceCountRequest request)
        {
            var resuelveData = new ResuelveData();
            var result = new InvoiceCountResponse();
            for (var currentDate = request.StartDate; currentDate <= request.EndDate; currentDate = currentDate.AddDays(1))
            {
                var currentRequest = new InvoiceCountRequest(request.CustomerId, currentDate, currentDate);
                var r = resuelveData.GetCustomerInvoicesCount(currentRequest);
            }

            return result;
        }
    }
}
