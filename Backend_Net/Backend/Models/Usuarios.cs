using System.ComponentModel.DataAnnotations;

namespace Backend.Models
{
    public class Usuarios
    {

        [Key]
        public int Id { get; set; }
        public int DocumentId { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Rol { get; set; }
        public DateTime FechRegistro { get; set; }
        public string CodValid { get; set; }
        public int Celular { get; set; }
    }
}
