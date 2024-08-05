namespace _14_Delegados_Func_Action.Models
{
    public class Bar
    {
        public string Nombre { get; set; }
        public List<Cerveza> cervezas = new List<Cerveza>();

        public Bar(string Nombre)
        {
            this.Nombre = Nombre;

        }
    }
}
