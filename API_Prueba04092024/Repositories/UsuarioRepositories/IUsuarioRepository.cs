using API_Prueba04092024.Models;

namespace API_Prueba04092024.Repositories.UsuarioRepositories
{
    public interface IUsuarioRepository
    {

        List<Usuario> usuarios();

        Usuario login(Login login);

    }
}
