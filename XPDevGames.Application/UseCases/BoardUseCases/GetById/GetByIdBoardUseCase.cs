
using XPDevGames.Infrastructure.Repositories;

namespace XPDevGames.Application.UseCases.BoardUseCases.GetById
{
    public class GetByIdBoardUseCase
    {
        BoardRepository _boardRepository;

        public GetByIdBoardUseCase()
        {
            _boardRepository = new BoardRepository();
        }

        public BoardOutput Handle(int id)
        {
           var board = _boardRepository.GetById(id);

           var boardOutput = new BoardOutput(board.GameTitle, board.Description, board.Rules, board.CreatedAt);

           return boardOutput;
        }
    }
}
