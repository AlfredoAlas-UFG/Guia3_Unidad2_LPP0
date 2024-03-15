using System.Data.SqlClient;
using System.Reflection.PortableExecutable;

namespace Guia_3.DTOs
{
    internal class UsuarioDTO
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string mail { get; set; }
        public int paisId { get; set; }

        public UsuarioDTO() { }

        public UsuarioDTO(SqlDataReader reader)
        {
            id = reader.GetInt32(0);
            nombre = reader.GetString(1);
            apellido = reader.GetString(2);
            mail = reader.GetString(3);
            paisId = reader.GetInt32(4);
        }
    }
}
