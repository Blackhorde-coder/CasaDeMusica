using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CasaDeMusica.Controllers
{
    public class InstrumentosController : Controller
    {
        // GET: Instrumentos
        public ActionResult Index()
        {
            return View();
        }
    }
}