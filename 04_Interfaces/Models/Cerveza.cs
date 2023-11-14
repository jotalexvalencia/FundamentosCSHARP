namespace _04_Interfaces.Models
{
    class Cerveza : Bebida, IBebidaAlcoholica
    {
        public int Alcohol { get; set; }    
        public Cerveza(int Cantidad, string Nombre = "Cerveza") : base(Nombre, Cantidad)
        {

        }

        public void MaxRecomendado()
        {
            Console.WriteLine("EL máximo permitido son 10 botellas");
        }
    }
}
