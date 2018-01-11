using CustomerInvoicesModels.Request;
using CustomerInvoicesUtils.Utils;
using CustomerInvoicesUtils.Web;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerInvoicesData
{
    public class ResuelveData
    {
        private string url = CommonUtils.GetAppSetting("ResuelveUrl");

        public string GetCustomerInvoicesCount(InvoiceCountRequest request)
        {
            var result = string.Empty;
            var prms = new Dictionary<string, string>();
            prms.Add("id", request.CustomerId);
            prms.Add("start", request.StartDate.ToString("YYYY-MM-DD"));
            prms.Add("finish", request.EndDate.ToString("YYYY-MM-DD"));

            var response = new WebUtils(url, prms).GetHttpRequest();
            return response;
        }
    }
}
