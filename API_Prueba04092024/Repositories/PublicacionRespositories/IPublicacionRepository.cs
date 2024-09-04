using API_Prueba04092024.Models;

namespace API_Prueba04092024.Repositories.PublicacionRespositories
{
    public interface IPublicacionRepository
    {
        List<Publicacion> publicaciones();

        Publicacion postPublicacion(Publicacion publicacion);




    }
}
