using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CasaDeMusica.Models
{
    public class Tipo
    {
        private int idtipo;
        private string nombre;

        public int Idtipo { get => idtipo; set => idtipo = value; }
        public string Nombre { get => nombre; set => nombre = value; }
    }
}