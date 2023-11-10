namespace _01_TiposDatosyVar
{
    class Program
    {
        static void Main(string[] args)
        {
            byte numero = 255; // 0 - 255
            sbyte numero2 = -128; // se reduce a la mitad -128 a 127 
            int numero3 = -12345; //2147 millones
            uint numero4 = 123456; // numeros enteros solamente positivos
            long numero5 = -12000000; // numeros mas largos pos y nega trillones de datos
            ulong numero6 = 12000000; // numeros solamente positivos 
            float numero7 = 189.1f; // punto flotante definir con letra f 
            double numero8 = 12000000.90d; // double definir con letra d
            decimal numero9 = 12000000000.99m; // decimal definir con una m 
            char caracter = '/'; // un caracter
            string palabra = "hola mundo"; // cadena de caracteres
            DateTime fecha = DateTime.Now;  // clase
            bool state = false; // falso o verdadero
            int? numero10 = null;
            var nombre = "Alex";// permite almacenar 
            Console.WriteLine($"{numero} {numero2}");
            Console.WriteLine($"{numero3} {numero4}");
            Console.WriteLine($"{numero5} {numero6}");
            Console.WriteLine($"{numero7} {numero8}");
            Console.WriteLine($"{numero9}");
            Console.WriteLine("char: {0} string: {1} DateTime: {2} bool: {3}", caracter, palabra, fecha, state);
            Console.WriteLine("entero? que permite null: {0}, var nombre:{1}", numero10, nombre);
            object persona = new { nombre = "Alex", apellido = "Valencia" }; // {} representan valor anonimo
            Console.WriteLine("object {0}", persona);
            var persona2 = new { nombre = "Alba", apellido = "Valencia", edad = 70 };
            Console.WriteLine("var persona 2 nombre {0} edad {1}", persona2.nombre+" "+persona2.apellido, persona2.edad);
        }

    }

}

