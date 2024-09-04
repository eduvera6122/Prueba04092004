using API_Prueba04092024.Models;

namespace API_Prueba04092024.Services.UsuarioServices
{
    public interface IUsuarioServices
    {
        List<Usuario> usuarios();
        Usuario login(Login login);


    }
}
