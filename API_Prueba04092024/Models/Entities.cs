using System.ComponentModel.DataAnnotations;

namespace API_Prueba04092024.Models
{
    public class Usuario
    {
        [Key]
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public List<Publicacion> Publicaciones { get; set; }
    }

    public class Publicacion
    {
        [Key]
        public int PostId { get; set; }
        public string Titulo { get; set; }
        public string Contenido { get; set; }
        public DateTime FechaPublicacion { get; set; }

        public int UserId { get; set; }
        public Usuario Usuario { get; set; }

    }

    public class PublicacionDAO
    {
        public string Titulo { get; set; }
        public string Contenido { get; set; }
        public DateTime FechaPublicacion { get; set; }

        public int UserId { get; set; }

    }


    public class Login
    {
        public string Username { get; set; }
        public string Password { get; set; }

    }

    public class TokenResponse{
        
        public string token { get; set; }

        public Usuario usuario { get; set; }
    
    }


}
