using Microsoft.AspNetCore.Mvc;
using XPDevGames.Domain.Dto;
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
        public IActionResult Add([FromBody] BoardDto board)
        {
            var _boarRepository = new BoardRepository();

            _boarRepository.Add(board);


            return Ok("board inserido com sucesso");
        }


    }
}
