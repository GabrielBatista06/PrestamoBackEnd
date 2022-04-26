using System;
using System.ComponentModel.DataAnnotations;

namespace PrestamoGJ.Domain.Entities
{
    public class Usuario
    {
        [Key]
        public int idtrabajador { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string sexo { get; set; }
        public DateTime fecha_nac { get; set; }
        public string num_documento { get; set; }
        public string direccion { get; set; }
        public string email { get; set; }
        public string acceso { get; set; }

    }
}
