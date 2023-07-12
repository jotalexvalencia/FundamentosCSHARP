using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentosCSHARP.Models
{
    class Bebida
    {
        public Bebida(string Nombre, int Cantidad)
        {
            this.Nombre = Nombre;
            this.Cantidad = Cantidad;
        }

        public string Nombre { get; set; }

        public int Cantidad { get; set; }

        public void Beberse(int CuantoBebio) 
        { 
            this.Cantidad -= CuantoBebio;
        }
    }
}
