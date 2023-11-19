using System;
using System.Collections.Generic;
using XPDevGames.Domain.Dto;
using XPDevGames.Infrastructure.Repositories;

namespace XPDevGames.Application.UseCases.BoardUseCases.GetAll
{
    public class GetAllBoardUseCase
    {
        BoardRepository _boardRepository;
        public GetAllBoardUseCase()
        {
            _boardRepository = new BoardRepository();
        }

        public  List<BoardDto> Handle()
        {
           var boards = _boardRepository.GetAll();

          return boards;
        }
    }
}
