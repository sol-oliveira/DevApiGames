using XPDevGames.Domain.Models;
using XPDevGames.Infrastructure.Repositories;

namespace XPDevGames.Application.UseCases.BoardUseCases.AddBoard
{
    public class AddBoardUseCase
    {
        BoardRepository _boardRepository;
        public AddBoardUseCase()
        {
            _boardRepository = new BoardRepository();
        }
        public void Handle(BoardInput input)
        {
            var board = new Board(input.GameTitle, input.Description, input.Rules);

            _boardRepository.Add(board);

        }
    }
}
