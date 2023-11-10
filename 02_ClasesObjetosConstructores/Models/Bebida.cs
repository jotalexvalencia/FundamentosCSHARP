using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_ClasesObjetosConstructores.Models
{
    class Bebida
    {
        public string Nombre { get; set; }
        public int Cantidad { get; set; }
        public Bebida(string nombre, int cantidad)
        {
            this.Nombre = nombre;
            this.Cantidad = cantidad;
        }
        public void Beberse(int CuantoBebio)
        {
            this.Cantidad -= CuantoBebio;
        }
    }
}
