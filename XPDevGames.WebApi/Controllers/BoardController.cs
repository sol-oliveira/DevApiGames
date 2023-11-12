using Microsoft.AspNetCore.Mvc;
using XPDevGames.Domain.Models;
using XPDevGames.Infrastructure.Repositories;

namespace XPDevGames.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BoardController : ControllerBase
    {
        

        [HttpGet]
        public IActionResult Get()
        {
            var obj = new BoardRepository();

            return Ok(obj.Get());
        }
    }
}
