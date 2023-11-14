using _04_Interfaces.Models;

namespace _04_Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            var bebidaAlcoholica = new Cerveza(100);
            MostrarRecomendacion(bebidaAlcoholica);
        }

        static void MostrarRecomendacion(IBebidaAlcoholica bebida)
        {
            bebida.MaxRecomendado();
        }
    }
}