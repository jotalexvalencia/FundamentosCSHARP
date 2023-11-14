using _05_ConexionBDObtenerInformacion.Models;

namespace _05_ConexionBDObtenerInformacion
{
    class Program
    {
        private static void Main(string[] args)
        {
            CervezaBD cervezaBD = new CervezaBD();

            var cervezas = cervezaBD.Get();

            foreach (var cerveza in cervezas)
            {
                Console.WriteLine(cerveza.Nombre);
            }
        }
    }
}