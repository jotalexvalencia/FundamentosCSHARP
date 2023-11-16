using _09_EnvioInformacionServiciosWebHTTPPostPutDelete.Models;

namespace _09_EnvioInformacionServiciosWebHTTPPostPutDelete.Models
{
    class Vino : Bebida, IBebidaAlcoholica
    {
        public int Alcohol { get; set; }
        public Vino(int Cantidad, string Nombre = "Vino")
            : base(Nombre, Cantidad)
        {

        }

        public void MaxRecomendado()
        {
            Console.WriteLine("EL máximo permitido son 3 copas");
        }
    }
}
