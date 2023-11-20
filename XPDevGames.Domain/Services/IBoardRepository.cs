using XPDevGames.Domain.Dto;
using XPDevGames.Domain.Models;

namespace XPDevGames.Domain.Services
{
    public interface IBoardRepository
    {
        List<BoardDto> GetAll();
        BoardDto GetById(int id);
        void Add(Board board);
    }
}
