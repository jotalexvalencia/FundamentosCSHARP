using System;
using FundamentosCSHARP.Models;
namespace FundamentosCSHARP
{
    class Program
    {
        static void Main(string[] args)
        {
            //byte numero = 255; // 0 -255 no permite negativos
            //sbyte numero2 = -128; // 0 - 255 puedo poner números negativos se reduce desde -128 hasta 127
            //uint numero3 = 0; // positivos la u
            //byte? numero4 = null;//permite null

            //var persona = new { nombre = "Héctor", apellido = "De León", };
            //Console.WriteLine(persona.nombre);

            // 2 clases objetos y constructores
            Bebida bebida = new Bebida("Coca cola", 1000);
            bebida.Beberse(500);
            Console.WriteLine(bebida.Cantidad);

            Cerveza cerveza = new Cerveza(500);
            cerveza.Beberse(10);
        }
    }
}

