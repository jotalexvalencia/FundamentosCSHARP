namespace _09_EnvioInformacionServiciosWebHTTPPostPutDelete.Models
{
    class Cerveza : Bebida, IBebidaAlcoholica
    {
        public int Alcohol { get; set; }
        public string Marca { get; set; }

        public Cerveza() : base(null, 0)
        {

        }
        public Cerveza(int Cantidad, string Nombre = "Cerveza") : base(Nombre, Cantidad)
        {

        }

        public void MaxRecomendado()
        {
            Console.WriteLine("EL máximo permitido son 10 botellas");
        }
    }
}
