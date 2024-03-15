using System.Data.SqlClient;

namespace Guia_3.DTOs
{
    internal class PaisDTO
    {
        public int paisId { get; set; }
        public string nombrePais { get; set; }

        public PaisDTO(SqlDataReader reader)
        {
            paisId = reader.GetInt32(0);
            nombrePais = reader.GetString(1);
        }
    }
}
