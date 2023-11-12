using Microsoft.AspNetCore.Mvc;
using XPDevGames.Domain.Models;

namespace XPDevGames.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommentController : ControllerBase
    {
        [HttpGet]
        public IActionResult Index()
        {
            Comment obj = new Comment("titulo de teste", "description de teste", "Pedro", 1);
            
            return Ok(obj);
        }
    }
}
