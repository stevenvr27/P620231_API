﻿namespace P620231_API.ModelsDTOs
{
    public class UserDTOs
    {
        public int IDUsuario { get; set; }
        public string Nombre { get; set; } = null!;
        public string Correo { get; set; } = null!;
        public string NumeroTelefono { get; set; } = null!;
        public string Contrasennia { get; set; } = null!;
        public string? Cedula { get; set; }
        public string? Direccion { get; set; }
        public int IdRol { get; set; }
        public int IdEstado { get; set; }
        public string EstadoDescripcion { get; set; } = null!;
        public string RolDescripcion { get; set; } = null!;


    }
}
