using CasaDeMusica.DTO;
using CasaDeMusica.Models;
using CasaDeMusica.GestorDatos;
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
        public ActionResult Alta()
        {
            GestorDatos.GestorDatos gestor = new GestorDatos.GestorDatos();
            DTOinstrumento dto = new DTOinstrumento();
            List<Tipo> listado = gestor.listadetipos(); ;
            dto.Listatipos = listado;
            return View(dto);
        }
        [HttpPost]
        public ActionResult Alta(DTOinstrumento dto)
        {
            GestorDatos.GestorDatos gestor = new GestorDatos.GestorDatos();
            gestor.agregarinstrumento(dto.I);
            List<Instrumento> lista = gestor.listadeinstrumentos();

            return View();
        }
    }
}