using API_Prueba04092024.Models;
using API_Prueba04092024.Services.UsuarioServices;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace API_Prueba04092024.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {

        private readonly IUsuarioServices _service;
        private readonly IConfiguration _configuration;

        public UsuarioController(IUsuarioServices service, IConfiguration configuration)
        {
            _service = service;
            _configuration = configuration;
        }

        // GET: api/<UsuarioController>
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_service.usuarios());
        }



        [HttpPost("login")]
        public IActionResult Login([FromBody] Login model)
        {
            if (model == null)
            {
                return BadRequest(ModelState);
            }


            Usuario usuario = _service.login(model);


            if (usuario == null)
            {
                return Unauthorized();
            }

            TokenResponse response = new TokenResponse();
            

            response.token = GenerateJwtToken(usuario);
            response.usuario = usuario;



            return Ok(response);

        }


        private string GenerateJwtToken(Usuario user)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(_configuration["Jwt:Key"]);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new[]
                {
                new Claim(ClaimTypes.Name, user.UserName),
                new Claim(ClaimTypes.Role, "Admin")
            }),
                Expires = DateTime.UtcNow.AddMinutes(Convert.ToDouble(_configuration["Jwt:DurationInMinutes"])),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature),
                Issuer = _configuration["Jwt:Issuer"],
                Audience = _configuration["Jwt:Audience"]
            };
            var token = tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(token);
        }





    }
}
