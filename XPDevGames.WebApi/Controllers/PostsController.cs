using Microsoft.AspNetCore.Mvc;
using XPDevGames.Infrastructure.Repositories;

namespace XPDevGames.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostsController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {   
            var post = new PostRepository();          

            return Ok(post.Get());
        }
    }
}
