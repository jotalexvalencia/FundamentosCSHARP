using _13_excepciones.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_excepciones
{
    public class BarData
    {
        string Nombre { get; set; }
        public List<Bebida> bebidas = new List<Bebida>();

        public BarData(string Nombre)
        {
            this.Nombre = Nombre;

        }
    }
}
