namespace _09_EnvioInformacionServiciosWebHTTPPostPutDelete.Models
{
    interface IBebidaAlcoholica
    {
        public int Alcohol { get; set; }

        public void MaxRecomendado();
    }
}
