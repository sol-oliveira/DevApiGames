using Microsoft.AspNetCore.Mvc;
using XPDevGames.Application.UseCases.Board.AddBoard;
using XPDevGames.Application.UseCases.Board.GetAll;
using XPDevGames.Application.UseCases.Board.GetById;
using XPDevGames.Domain.Dto;

namespace XPDevGames.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BoardController : ControllerBase
    {        

        [HttpGet]
        public IActionResult GetAll()
        {
            var board = new GetAllBoardUseCase().Handle();

            return Ok(board);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var board = new GetByIdBoardUseCase().Handle(id);

            return Ok(board);
        }

        [HttpPost]
        public IActionResult Add([FromBody] BoardDto boardDto)
        {
             new AddBoardUseCase().Handle(boardDto);           

            return Ok("board inserido com sucesso");
        }


    }
}
