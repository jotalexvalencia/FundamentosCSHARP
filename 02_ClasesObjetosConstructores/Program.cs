using _02_ClasesObjetosConstructores.Models;


namespace _02_ClasesObjetosConstructores
{
    class Program
    {
        static void Main(string[] args)
        {
            Bebida bebida = new Bebida("Coca cola", 1000);
            bebida.Beberse(500);
            Console.WriteLine(bebida.Cantidad);
        }
    }
}

