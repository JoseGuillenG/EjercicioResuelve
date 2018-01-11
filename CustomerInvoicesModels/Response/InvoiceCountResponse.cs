using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerInvoicesModels.Response
{
    public class InvoiceCountResponse
    {
        public int CustomerInvoices { get; set; }
        public int Calls { get; set; }

        public InvoiceCountResponse()
        {
            this.CustomerInvoices = 0;
            this.Calls = 0;
        }

        public void AddInvoicesAndCalls(int customerInvoices, int calls)
        {
            this.CustomerInvoices += customerInvoices;
            this.Calls += calls;
        }
    }
}
