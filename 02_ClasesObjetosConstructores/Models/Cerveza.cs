using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_ClasesObjetosConstructores.Models
{
    class Cerveza : Bebida
    {
        //public Cerveza() : base("Cerveza",500)
        //{

        //}

        public Cerveza(int Cantidad, string Nombre = "Cerveza") : base(Nombre, Cantidad)
        {

        }
    }
}
