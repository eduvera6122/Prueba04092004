using API_Prueba04092024.Models;
using API_Prueba04092024.Repositories.PublicacionRespositories;
using API_Prueba04092024.Services.PublicacionesServices;
using API_Prueba04092024.Services.UsuarioServices;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace API_Prueba04092024.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    
    public class PublicacionController : ControllerBase
    {

        private readonly IPublicacionService _service;

        [HttpGet]
        public IActionResult Get()
        {
            return Ok();
        
        }   

       
        [HttpPost]
        public IActionResult Post([FromBody] PublicacionDAO publicacion)
        {
            if(publicacion == null)
            {
                return BadRequest();
            }

            return Ok(_service.postPublicacion(publicacion));

        }

      
    }
}
