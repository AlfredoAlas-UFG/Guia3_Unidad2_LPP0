using System.Data.SqlClient;

namespace Guia_3
{
    internal class DBConnection
    {
        private string ConnectionString =
            //Reemplazar por sus datos de conexión ingeniera :)
            "Data Source=;" +
            "Initial Catalog=GestionUsuarios;" +
            "User=;" +
            "Password=";

        public SqlConnection ObtenerConexion()
        {
            SqlConnection connection = new SqlConnection(ConnectionString);

            return connection;
        }
    }
}
