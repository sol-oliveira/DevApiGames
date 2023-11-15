
using XPDevGames.Domain.Dto;
using XPDevGames.Infrastructure.Repositories;

namespace XPDevGames.Application.UseCases.Board.GetById
{
    public class GetByIdBoardUseCase
    {
        BoardRepository _boardRepository;

        public GetByIdBoardUseCase()
        {
            _boardRepository = new BoardRepository();
        }

        public BoardDto Handle(int id)
        {
           return _boardRepository.GetById(id);
        }
    }
}
