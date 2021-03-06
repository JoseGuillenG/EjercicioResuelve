﻿using CustomerInvoicesModels.Request;
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
    /// <summary>
    /// Clase de transferencia de datos
    /// </summary>
    public class ResuelveData
    {
        /// <summary>
        /// Endpoint para realizar request
        /// </summary>
        private string url = CommonUtils.GetAppSetting("ResuelveUrl");

        /// <summary>
        /// Método para obtener la cantidad de facturas de un cliente en un rango de fechas
        /// </summary>
        /// <param name="request">Objeto request con los parámetros necesarios</param>
        /// <returns>Respuesta de la llamada en formato string</returns>
        public string GetCustomerInvoicesCount(InvoiceCountRequest request)
        {
            var result = string.Empty;
            var prms = new Dictionary<string, string>();
            prms.Add("id", request.CustomerId);
            prms.Add("start", request.StartDate.ToString("yyyy-MM-dd"));
            prms.Add("finish", request.EndDate.ToString("yyyy-MM-dd"));

            var response = new WebUtils(url, prms).GetHttpRequest();
            return response;
        }
    }
}
