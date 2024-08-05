﻿namespace _14_Delegados_Func_Action.Models
{
    class Vino : Bebida, IBebidaAlcoholica
    {
        public int Alcohol { get; set; }
        public Vino(int Cantidad, string Nombre = "Vino")
            : base(Nombre, Cantidad)
        {

        }

        public void MaxRecomendado()
        {
            Console.WriteLine("EL máximo permitido son 3 copas");
        }
    }
}
