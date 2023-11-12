using Microsoft.AspNetCore.Mvc;
using System.Reflection;
using XPDevGames.Domain.Models;

namespace XPDevGames.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostsController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {   
            var post = new Post("titulo de teste", "description de teste", 1);          

            return Ok(post);
        }
    }
}
