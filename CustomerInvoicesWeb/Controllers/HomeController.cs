using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CustomerInvoicesWeb.Controllers
{
    /// <summary>
    /// Controlador Home
    /// </summary>
    public class HomeController : Controller
    {
        /// <summary>
        /// Método Index, método encargado de mostrar la pantalla principal
        /// </summary>
        /// <returns>Regresa una vista</returns>
        public ActionResult Index()
        {
            return View();
        }
    }
}