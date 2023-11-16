namespace _09_EnvioInformacionServiciosWebHTTPPostPutDelete.Models
{
    class Bebida
    {
        public string Nombre { get; set; }
        public int Cantidad { get; set; }
        public Bebida(string nombre, int cantidad)
        {
            Nombre = nombre;
            Cantidad = cantidad;
        }
        public void Beberse(int CuantoBebio)
        {
            Cantidad -= CuantoBebio;
        }
    }
}
