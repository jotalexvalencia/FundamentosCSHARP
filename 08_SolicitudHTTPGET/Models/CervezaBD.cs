using System.Data.SqlClient;

namespace _08_SolicitudHTTPGET.Models
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

            using (var connection = new SqlConnection(connectionString))
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
        public void Add(Cerveza cerveza)
        {
            string query
                = "insert into cerveza(nombre, marca, alcohol, cantidad) " +
                "values(@nombre, @marca, @alcohol, @cantidad)";

            using (var connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@nombre", cerveza.Nombre);
                command.Parameters.AddWithValue("@marca", cerveza.Marca);
                command.Parameters.AddWithValue("@alcohol", cerveza.Alcohol);
                command.Parameters.AddWithValue("@cantidad", cerveza.Cantidad);

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
        }
        public void Edit(Cerveza cerveza, int Id)
        {
            string query
                = "update cerveza set nombre=@nombre, " +
                "marca=@marca, alcohol=@alcohol, cantidad=@cantidad " +
                "where id=@id";

            using (var connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@nombre", cerveza.Nombre);
                command.Parameters.AddWithValue("@marca", cerveza.Marca);
                command.Parameters.AddWithValue("@alcohol", cerveza.Alcohol);
                command.Parameters.AddWithValue("@cantidad", cerveza.Cantidad);
                command.Parameters.AddWithValue("@id", Id);

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
        }
        public void Delete(int Id)
        {
            string query
                = "delete from cerveza " +
                "where id=@id";

            using (var connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@id", Id);

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
        }
    }
}
