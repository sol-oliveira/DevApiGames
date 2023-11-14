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
        public IActionResult GetAll()
        {
            var bord = new BoardRepository();

            return Ok(bord.GetAll());
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var bord = new BoardRepository();

            return Ok(bord.GetById(id));
        }

        [HttpPost]
        public IActionResult Add([FromBody]Board board)
        {          

            var bordRepository = new BoardRepository();

            bordRepository.Add(board);

            return Ok("ffs");
        }


    }
}
