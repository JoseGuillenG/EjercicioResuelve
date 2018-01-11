using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace CustomerInvoicesUtils.Web
{
    /// <summary>
    /// Clase para ejecutar llamadas http
    /// </summary>
    public class WebUtils
    {
        /// <summary>
        /// End point a conectarse
        /// </summary>
        public string Url { get; set; }

        /// <summary>
        /// Listado de parámetros
        /// </summary>
        public Dictionary<string,string> Params { get; set; }

        /// <summary>
        /// Constructor para la clase webutils
        /// </summary>
        /// <param name="url">Endpoint a conectar</param>
        /// <param name="paramList">Listado de parámetros</param>
        public WebUtils(string url, Dictionary<string, string> paramList)
        {
            this.Url = url;
            this.Params = paramList;
        }

        /// <summary>
        /// Método para ejecutar un reqest get
        /// </summary>
        /// <returns>Response de tipo string</returns>
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

        /// <summary>
        /// Genera el endpoint de tipo get con parámetros, listo para ser enviado
        /// </summary>
        /// <returns>Endpoint completo</returns>
        private string GetUrlToSend()
        {
            var prms = string.Join("&", this.Params.Select(x => string.Format("{0}={1}", x.Key, x.Value)));
            var result = Url + prms;
            return result;
        }
    }
}
