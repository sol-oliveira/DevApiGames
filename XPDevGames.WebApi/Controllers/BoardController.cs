using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using XPDevGames.WebApi.Models;

namespace XPDevGames.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BoardController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            Board obj = new Board("Termo", "o jogo termo tem como objetivo adivinhação de palavras", "Não pode  passar  de  06 palavras"); 
            return Ok(obj);
        }
    }
}
