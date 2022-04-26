using System;

namespace PrestamoGJ.Application.Core.Dtos
{
    public class UsuarioDto
    {
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string sexo { get; set; }
        public DateTime fecha_nac { get; set; }
        public string num_documento { get; set; }
        public string direccion { get; set; }
        public string email { get; set; }
        public string acceso { get; set; }
        public string usuario { get; set; }
        public string password { get; set; }
    }
}
