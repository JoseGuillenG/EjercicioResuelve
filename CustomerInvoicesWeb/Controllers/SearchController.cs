using CustomerInvoicesLogic;
using CustomerInvoicesModels.Request;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Helpers;
using System.Web.Mvc;
using System.Web.Script.Serialization;

namespace CustomerInvoicesWeb.Controllers
{
    public class SearchController : Controller
    {
        public JsonResult normalSearch(string customerId, string startDate, string endDate)
        {
            var sDate = DateTime.MinValue;
            var eDate = DateTime.MinValue;

            if (DateTime.TryParse(startDate, out sDate) && DateTime.TryParse(endDate, out eDate))
            {
                var request = new InvoiceCountRequest(customerId, sDate, eDate);
                var result = new PerDayLogic().GetCustomerInvoicesCount(request);
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            else
            {
                Response.StatusCode = (int)HttpStatusCode.InternalServerError;
                return Json(new { message = "Error" }, JsonRequestBehavior.AllowGet);
            }
        }

        public JsonResult halfSearch(string customerId, string startDate, string endDate)
        {
            var sDate = DateTime.MinValue;
            var eDate = DateTime.MinValue;

            if (DateTime.TryParse(startDate, out sDate) && DateTime.TryParse(endDate, out eDate))
            {
                var request = new InvoiceCountRequest(customerId, sDate, eDate);
                var result = new HalfLogic().GetCustomerInvoicesCount(request);
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            else
            {
                Response.StatusCode = (int)HttpStatusCode.InternalServerError;
                return Json(new { message = "Error" }, JsonRequestBehavior.AllowGet);
            }
        }

        public JsonResult randomSearch(string customerId, string startDate, string endDate)
        {
            var sDate = DateTime.MinValue;
            var eDate = DateTime.MinValue;

            if (DateTime.TryParse(startDate, out sDate) && DateTime.TryParse(endDate, out eDate))
            {
                var request = new InvoiceCountRequest(customerId, sDate, eDate);
                var result = new RandomLogic().GetCustomerInvoicesCount(request);
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            else
            {
                Response.StatusCode = (int)HttpStatusCode.InternalServerError;
                return Json(new { message = "Error" }, JsonRequestBehavior.AllowGet);
            }
        }
    }
}