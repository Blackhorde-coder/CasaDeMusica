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
            return View("Listado", lista);
        }
        public ActionResult Listado()
        {
            GestorDatos.GestorDatos gestor = new GestorDatos.GestorDatos();
            List<Instrumento> lista = gestor.listadeinstrumentos();
            return View(lista);
        }
        public ActionResult Editar(int idinstrumento)
        {
            GestorDatos.GestorDatos gestor = new GestorDatos.GestorDatos();
            Instrumento i = gestor.buscarinstrumento(idinstrumento);
            DTOinstrumento dto = new DTOinstrumento();
            dto.I = i;
            dto.Listatipos = gestor.listadetipos();
            return View(dto);
        }
        [HttpPost]
        public ActionResult Editar(DTOinstrumento dto)
        {
            GestorDatos.GestorDatos gestor = new GestorDatos.GestorDatos();
            gestor.actualizarinstrumento(dto.I);
            List<Instrumento> lista = gestor.listadeinstrumentos();
            return View("Listado", lista);


        }
    }
}