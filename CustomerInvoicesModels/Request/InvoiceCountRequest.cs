using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerInvoicesModels.Request
{
    public class InvoiceCountRequest
    {
        public string CustomerId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public InvoiceCountRequest(string customerId, DateTime startDate, DateTime endDate)
        {
            this.CustomerId = customerId;
            this.StartDate = startDate;
            this.EndDate = endDate;
        }
    }
}
