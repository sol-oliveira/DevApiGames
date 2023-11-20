using Microsoft.AspNetCore.Mvc;
using XPDevGames.Application.UseCases.BoardUseCases.Add;
using XPDevGames.Application.UseCases.BoardUseCases.GetAll;
using MediatR;
using XPDevGames.Application.UseCases.BoardUseCases.GetById;

namespace XPDevGames.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BoardController : ControllerBase
    {
        private readonly IMediator _mediator;

        public BoardController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var board = await _mediator.Send(new BoardInputAll());

            return Ok(board);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {            
            var response = await _mediator.Send(new BoardInputById(id));           

            return Ok(response);
        }

        [HttpPost]
        public  async Task<IActionResult> Add([FromBody] BoardInput input)
        {
            await _mediator.Send(input);                  

            return Ok("board inserido com sucesso");
        }


    }
}
