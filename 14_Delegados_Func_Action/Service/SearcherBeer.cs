using _14_Delegados_Func_Action.Errors;
using _14_Delegados_Func_Action.Models;

namespace _14_Delegados_Func_Action.Service
{
    public class SearcherBeer
    {
        List<Cerveza> cervezas = new List<Cerveza>()
                    {
                        new Cerveza() { Alcohol = 7, Cantidad = 10, Nombre = "Pale Ale", Marca = "Minerva" },
                        new Cerveza() { Alcohol = 8, Cantidad = 5, Nombre = "Ticús", Marca = "Colimna"},
                        new Cerveza() { Alcohol = 7, Cantidad = 8, Nombre = "Stout", Marca = "Minerva"},
                    };
        public int GetCantidad(string Nombre)
        {
            var cerveza = (from d in cervezas
                           where d.Nombre == Nombre
                           select d).FirstOrDefault();

            if (cerveza == null)
                throw new BeerNotFoundException("La cerveza se ha terminado");

            return cerveza.Cantidad;

        }
    }
}
