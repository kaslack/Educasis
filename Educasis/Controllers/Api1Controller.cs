using Educasis.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Net;

namespace Educasis.Controllers
{

    [ApiController]
    [Route("Api's/[controller]")]
    public class Api1Controller : ControllerBase
    {

        [HttpGet]
        public IActionResult Get()
        {

            return Ok(new List<string>() { "Kevin Romero", "Adriana Osorio", "Mara Navarrete" });

        }

        [HttpGet("{user}")]
        public IActionResult user(string user)
        {
            user = "usuario " + user + " registrado con exito, vuelva al inicio para ingresar a la página.";
            return Ok(user);
        }
        
    }
    
}