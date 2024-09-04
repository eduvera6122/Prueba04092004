using API_Prueba04092024.Context;
using API_Prueba04092024.Models;

namespace API_Prueba04092024.Repositories.UsuarioRepositories
{
    public class UsuarioRepositorie : IUsuarioRepository
    {

        private AppDbContext _context;


        public UsuarioRepositorie(AppDbContext context)
        {
            _context = context;
        }



        public Usuario login(Login login)
        {
           Usuario usuario = _context.Usuarios.FirstOrDefault(u => u.UserName == login.Username && u.Password == login.Password);

            return usuario;
        }

        public List<Usuario> usuarios()
        {
            return _context.Usuarios.ToList();
        }
    }
}
