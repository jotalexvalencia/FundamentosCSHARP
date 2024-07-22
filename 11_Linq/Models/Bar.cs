using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_Linq.Models
{
    public class Bar
    {
        public string Nombre { get; set; }
        public List<Cerveza> cervezas = new List<Cerveza>();

        public Bar(string Nombre)
        {
            this.Nombre = Nombre;
            
        }
    }
}
