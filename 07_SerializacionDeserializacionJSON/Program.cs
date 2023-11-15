using _07_SerializacionDeserializacionJSON.Models;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace _07_SerializacionDeserializacionJSON
{
    class Program
    {
        static void Main(string[] args)
        {
            // Serializacion
            //Cerveza cerveza = new Cerveza(10, "Cerveza");
            //string miJson = JsonSerializer.Serialize(cerveza);
            //File.WriteAllText("objeto.txt", miJson);

            // Deserializacion
            string miJson2 = File.ReadAllText("objeto.txt");
            Cerveza cerveza1 = JsonSerializer.Deserialize<Cerveza>(miJson2);
        }
    }
}