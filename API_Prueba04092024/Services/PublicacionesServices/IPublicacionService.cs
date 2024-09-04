using API_Prueba04092024.Models;

namespace API_Prueba04092024.Services.PublicacionesServices
{
    public interface IPublicacionService
    {
        List<Publicacion> publicaciones();
        Publicacion postPublicacion(PublicacionDAO publicacion);

    }
}
