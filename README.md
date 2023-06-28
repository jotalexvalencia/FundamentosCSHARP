# FundamentosCSHARP

namespace FundamentosCSHARP
{
    class Program
    {
        static void Main(string[] args)
        {
            byte numero = 255; // 0 -255 no permite negativos
            sbyte numero2 = -128; // 0 - 255 puedo poner números negativos se reduce desde -128 hasta 127
            uint numero3 = 0; // positivos la u
            byte? numero4 = null;//permite null

            var persona = new { nombre = "Héctor", apellido = "De León", };
            Console.WriteLine(persona.nombre);
        }
    }
}

