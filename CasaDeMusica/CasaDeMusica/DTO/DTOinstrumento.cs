using CasaDeMusica.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CasaDeMusica.DTO
{
    public class DTOinstrumento
    {
        private Instrumento i;
        private List<Tipo> listatipos;

        public Instrumento I { get => i; set => i = value; }
        public List<Tipo> Listatipos { get => listatipos; set => listatipos = value; }
    }
}