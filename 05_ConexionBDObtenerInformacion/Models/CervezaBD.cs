using System.Data;
using System.Data.SqlClient;

namespace _05_ConexionBDObtenerInformacion.Models
{
    class CervezaBD
    {
        private string connectionString
            = @"Data Source=LAPTOP-DR5N7U4N\SQLEXPRESS;Initial Catalog=FundamentosCSharp;" +
            "User=sa;Password=750929";

        public List<Cerveza> Get() 
        { 
            List<Cerveza> cervezas = new List<Cerveza>();

            string query = "select nombre, marca, alcohol, cantidad from cerveza";

            using (SqlConnection connection = new SqlConnection(connectionString))
            { 
                SqlCommand command = new SqlCommand(query, connection);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    int Cantidad = reader.GetInt32(3);
                    string Nombre = reader.GetString(0);
                    Cerveza cerveza = new Cerveza(Cantidad, Nombre);
                    cerveza.Alcohol = reader.GetInt32(2);
                    cerveza.Marca = reader.GetString(1);
                    cervezas.Add(cerveza);
                }
                reader.Close();
                connection.Close();
            }

            return cervezas;
        }
    }
}
