using System.ComponentModel.DataAnnotations;

namespace PrestamoGJ.Application.Core.Dtos
{
    public class RequestLoginDto
    {
        [Required]
        public string usuario { get; set; }
        [Required]
        public string password { get; set; }
    }
}
