using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_excepciones.Errors
{
    public class BeerNotFoundException : Exception
    {
        public BeerNotFoundException() : base() { }
        public BeerNotFoundException(string message): base(message) { }
        public BeerNotFoundException(string message, Exception inner): base(message, inner) { }                   
    }
}
