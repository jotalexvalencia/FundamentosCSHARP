using _06_ConexionBDCRUD.Models;

namespace _06_ConexionBDCRUD
{
    class Program
    {
        static void Main(string[] args)
        {
            CervezaBD cervezaBD = new CervezaBD();

            // insertamos nueva cerveza
            // con las llaves creamos un universo que permite usar cerveza solo en ese universo
            //{
            //    Cerveza cerveza = new Cerveza(29, "Budeweiser");
            //    cerveza.Marca = "Minerva";
            //    cerveza.Alcohol = 15;
            //    cervezaBD.Add(cerveza);
            //}

            // editar una cerveza
            //{
            //    Cerveza cerveza = new Cerveza(9, "Pale ale");
            //    cerveza.Marca = "Minerva";
            //    cerveza.Alcohol = 9;
            //    cervezaBD.Edit(cerveza, 9);
            //}

            // eliminar una cerveza
            {
                cervezaBD.Delete(9);
            }

            // obtener todad las cervezas
            var cervezas = cervezaBD.Get();

            foreach (var cerveza in cervezas)
            {
                Console.WriteLine(cerveza.Nombre);
            }
        }
    }
}