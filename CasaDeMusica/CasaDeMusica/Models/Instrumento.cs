using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CasaDeMusica.Models
{
    public class Instrumento
    {
        private int idinstrumento;
        private string nombre;
        private string descripcion;
        private int stock;
        private double precio;
        private int idtipo;

        public int Idinstrumento { get => idinstrumento; set => idinstrumento = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public int Stock { get => stock; set => stock = value; }
        public double Precio { get => precio; set => precio = value; }
        public int Idtipo { get => idtipo; set => idtipo = value; }
    }
}