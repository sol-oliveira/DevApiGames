using Microsoft.AspNetCore.Mvc;
using XPDevGames.Application.UseCases.BoardUseCases.AddBoard;
using XPDevGames.Application.UseCases.BoardUseCases;
using XPDevGames.Application.UseCases.BoardUseCases.GetById;
using XPDevGames.Domain.Dto;
using XPDevGames.Application.UseCases.BoardUseCases.GetAll;

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
        public IActionResult Add([FromBody] BoardInput input)
        {
             new AddBoardUseCase().Handle(input);           

            return Ok("board inserido com sucesso");
        }


    }
}
