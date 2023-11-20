using _10_Generics.Models;

namespace _10_Generics
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var cerveza = new Cerveza()
            { Alcohol = 5, Cantidad = 500, Marca = "Colima", Nombre = "Ticús" };

            var post = new Post() { body = "soy un body", title = "hola", userId = 50 };

            Service.SendRequest<Post> service = new Service.SendRequest<Post>();

            var CervezaRespuesta = await service.Send(post);
        }
    }
}