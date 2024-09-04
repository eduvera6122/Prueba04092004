using API_Prueba04092024.Context;
using API_Prueba04092024.Models;
using System.Diagnostics.Metrics;

namespace API_Prueba04092024.Repositories.PublicacionRespositories
{
    public class PublicacionRepository : IPublicacionRepository
    {
        private AppDbContext _context;

        public PublicacionRepository(AppDbContext context)
        {
            _context = context;
        }

        public Publicacion postPublicacion(Publicacion publicacion)
        {
            _context.Publicaciones.Add(publicacion);

            int result = _context.SaveChanges();

            if (result > 0)
            {
                return publicacion;
            }
            else
            {
                return null;
            }


        }

        public List<Publicacion> publicaciones()
        {
           return _context.Publicaciones.ToList();
        }
    }
}
