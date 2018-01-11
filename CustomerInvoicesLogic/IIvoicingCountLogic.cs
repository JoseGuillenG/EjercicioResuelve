using CustomerInvoicesModels.Request;
using CustomerInvoicesModels.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerInvoicesLogic
{
    public interface IIvoicingCountLogic
    {
        InvoiceCountResponse GetCustomerInvoicesCount(InvoiceCountRequest request);
    }
}
