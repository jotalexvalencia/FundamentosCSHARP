namespace _14_Delegados_Func_Action.Models
{
    public class BarData
    {
        string Nombre { get; set; }
        public List<Bebida> bebidas = new List<Bebida>();

        public BarData(string Nombre)
        {
            this.Nombre = Nombre;

        }
    }
}
