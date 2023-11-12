using Microsoft.AspNetCore.Mvc;
using XPDevGames.Infrastructure.Repositories;

namespace XPDevGames.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommentController : ControllerBase
    {
        [HttpGet]
        public IActionResult Index()
        {
            var obj = new CommentRepository();
            
            return Ok(obj.Get());
        }
    }
}
