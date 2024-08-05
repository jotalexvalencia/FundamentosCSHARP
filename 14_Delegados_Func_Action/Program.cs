using System.Threading.Channels;

namespace _14_Delegados_Func_Action
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Action<string, string> mostrar =
                (a,b) => Console.WriteLine(a+b);
            HacerAlgo(mostrar);
        }
        public static void HacerAlgo(Action<string, string> funcionFinal)
        {
            Console.WriteLine("hago algo");
            funcionFinal("se envio desde otra función ","otra");
            Console.WriteLine("hago algo más");
        }
        public static void Show(string cad, string cad2)
        {
            Console.WriteLine(cad + cad2);
        }
        public static int Show(string cad)
        {
            return cad.Count();
        }
    }
}