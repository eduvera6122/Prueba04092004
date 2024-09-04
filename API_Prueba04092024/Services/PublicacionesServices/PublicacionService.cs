using API_Prueba04092024.Models;
using API_Prueba04092024.Repositories.PublicacionRespositories;

namespace API_Prueba04092024.Services.PublicacionesServices
{
    public class PublicacionService : IPublicacionService
    {

        private readonly IPublicacionRepository _repository;

        public PublicacionService(IPublicacionRepository repository)
        {
            _repository = repository;
        }

        public Publicacion postPublicacion(PublicacionDAO publicacion)
        {
            Publicacion publicacion1 = new Publicacion();


            publicacion1.Titulo = publicacion.Titulo;
            publicacion1.Contenido = publicacion.Contenido;
            publicacion1.UserId = publicacion.UserId;
            publicacion1.FechaPublicacion = publicacion.FechaPublicacion;
           
            return _repository.postPublicacion(publicacion1);   
        }

        public List<Publicacion> publicaciones()
        {
            return _repository.publicaciones();
        }
    }
}
