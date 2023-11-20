using _11_Linq.Models;

namespace _11_Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Cerveza> cervezas = new List<Cerveza>()
            {
                new Cerveza() {Alcohol=7, Cantidad=10, Nombre="Pale Ale", Marca="Minerva" },
                new Cerveza() {Alcohol=8, Cantidad=5, Nombre="Ticús", Marca="Colimna"},
                new Cerveza() {Alcohol =7, Cantidad=8, Nombre="Stout", Marca="Minerva"},
                new Cerveza() {Alcohol=6, Cantidad=100, Nombre="Piedra Lisa", Marca="Colima"}
            };

            var cervezasOrdenadas = from d in cervezas
                                    where d.Nombre == "Pale Ale" && d.Marca == "Minerva"
                                    orderby d.Nombre
                                    select d;
            foreach (var cerveza in cervezasOrdenadas)
            {
                Console.WriteLine($"{cerveza.Nombre} {cerveza.Marca}");
            }
        }
    }
}