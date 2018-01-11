using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace CustomerInvoicesUtils.Web
{
    public class WebUtils
    {
        public string Url { get; set; }

        public Dictionary<string,string> Params { get; set; }

        public WebUtils(string url, Dictionary<string, string> paramList)
        {
            this.Url = url;
            this.Params = paramList;
        }

        public string GetHttpRequest()
        {
            WebClient client = new WebClient();
            client.Headers.Add("user-agent", "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.2; .NET CLR 1.0.3705;)");
            Stream data = client.OpenRead(GetUrlToSend());
            StreamReader reader = new StreamReader(data);
            string s = reader.ReadToEnd();
            data.Close();
            reader.Close();

            return s;
        }

        private string GetUrlToSend()
        {
            var prms = string.Join("&", this.Params.Select(x => string.Format("{0}={1}", x.Key, x.Value)));
            var result = Url + prms;
            return result;
        }
    }
}
