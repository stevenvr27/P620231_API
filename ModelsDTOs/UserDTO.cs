namespace P620231_API.ModelsDTOs
{
    public class UserDTO
    {
        public int IDUsuario { get; set; }
        public string Nombre { get; set; } = null!;
        public string Correo { get; set; } = null!;
        public string Telefono { get; set; } = null!;
        public string Contrasennia { get; set; } = null!;
        public string? Cedula { get; set; }
        public string? Direccion { get; set; }
        public int IDROl { get; set; }
        public int IDEstado { get; set; }

        public string EstadoDescription { get; set; } = null !;
        public string RolDescripcion { get; set; } = null!;


    }
}
