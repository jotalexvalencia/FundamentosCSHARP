using _3_ArreglosListas.Models;

namespace _3_ArreglosListas
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };

            for (int i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine("iteración: " + i + " - " + numeros[i]);
            }

            foreach (var numero in numeros)
            {
                Console.WriteLine(numero);
            }
            Console.WriteLine("********************************************");
            List<int> lista = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8 };
            //Queue<int> queue = new Queue<int>();// Colas
            //Stack<int> stack = new Stack<int>();//Pilas
            lista.Add(9);
            lista.Add(0);
            lista.Remove(2);

            foreach (var numero in lista)
            {
                Console.WriteLine("elemento: " + numero);
            }

            List<Cerveza> cervezas = new List<Cerveza>() { new Cerveza(10, "Cerveza premium") };
            cervezas.Add(new Cerveza(500));
            Cerveza erdinger = new Cerveza(500, "Cerveza de trigo");
            cervezas.Add(erdinger);

            foreach (var cerveza in cervezas)
            {
                Console.WriteLine("cerveza: " + cerveza.Nombre);
            }
        }
    }
}