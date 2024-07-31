using _13_excepciones.Errors;
using _13_excepciones.Service;

namespace _13_excepciones
{
    class Program
    {
        static async Task Main(string[] args)
        {
            try
            {
                var searcherBeer = new SearcherBeer();
                //var cantidad = searcherBeer.GetCantidad("ajdhasjdjh");
                var cantidad = searcherBeer.GetCantidad("Stoutklkñlkñkñkñkñkñk");
                Console.WriteLine("Todo bien");
            } 
            catch (FieldAccessException e)
            {
                Console.WriteLine("si te he cachado");
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine("Ha caido en una operación invalida");
            } 
            catch(BeerNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex) 
            {
                Console.WriteLine("una excepción no esperada");
            }
            finally
            {
                Console.WriteLine("Esto siempre se ejecuta");
            }
        }
    }
}