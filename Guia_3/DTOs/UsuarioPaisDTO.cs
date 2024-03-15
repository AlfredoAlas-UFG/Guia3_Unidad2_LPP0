namespace Guia_3.DTOs
{
    internal class UsuarioPaisDTO
    {
        public UsuarioPaisDTO(UsuarioDTO usuario, string nombrePais)
        {
            NombrePais = nombrePais;
            id= usuario.id;
            nombre = usuario.nombre;
            apellido = usuario.apellido;
            mail = usuario.mail;
        }

        public int id { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string mail { get; set; }
        public string NombrePais { get; set; }
    }
}
