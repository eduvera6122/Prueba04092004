using API_Prueba04092024.Context;
using API_Prueba04092024.Models;
using API_Prueba04092024.Repositories.UsuarioRepositories;

namespace API_Prueba04092024.Services.UsuarioServices
{
    public class UsuarioService : IUsuarioServices
    {

        private readonly IUsuarioRepository _repository;

        public UsuarioService(IUsuarioRepository repository)
        {
            _repository = repository;
        }

        public Usuario login(Login login)
        {
            Usuario usuario = _repository.login(login);
            return usuario;
        }

        public List<Usuario> usuarios()
        {
          return _repository.usuarios();
        }
    }
}
