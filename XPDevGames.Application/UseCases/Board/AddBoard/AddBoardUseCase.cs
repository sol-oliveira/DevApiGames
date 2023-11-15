using XPDevGames.Domain.Dto;
using XPDevGames.Infrastructure.Repositories;

namespace XPDevGames.Application.UseCases.Board.AddBoard
{
    public class AddBoardUseCase
    {
        BoardRepository _boardRepository;
        public AddBoardUseCase()
        {
            _boardRepository = new BoardRepository();
        }
        public void Handle(BoardDto boardDto)
        {
            _boardRepository.Add(boardDto);
        }
    }
}
