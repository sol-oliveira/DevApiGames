using Dapper;
using System.Data;
using System.Data.SqlClient;
using XPDevGames.Domain.Dto;


namespace XPDevGames.Infrastructure.Repositories
{
    public class BoardRepository
    {
        private const string connectionString = "";
          
         public List<BoardDto> GetAll()
         {
            var sql = "SELECT GAME_TITLE AS GameTitle, DESCRIPTION, RULES, CREATED_AT FROM BOARD";

            using IDbConnection connection = new SqlConnection(connectionString);

            var boardDto = connection.Query<BoardDto>(sql);

            return boardDto.ToList();
         }


        public BoardDto GetById(int id)
        {
            var sql = "SELECT GAME_TITLE AS GameTitle, DESCRIPTION, RULES, CREATED_AT FROM BOARD WHERE ID = @id";

            using IDbConnection connection = new SqlConnection(connectionString);

            var boardDto = connection.QueryFirstOrDefault<BoardDto>(sql, new { ID = id });

            return boardDto;
        }

        public void Add(BoardDto board)
        {
            var sql = "INSERT INTO BOARD (GAME_TITLE, DESCRIPTION, RULES, CREATED_AT) VALUES (@GameTitle, @Description, @Rules, CURRENT_TIMESTAMP)";

            var parameters = new
            {
                GameTitle = board.GameTitle,
                Description = board.Description,
                Rules = board.Rules
            };


            using IDbConnection connection = new SqlConnection(connectionString);

        
            connection.Execute(sql, parameters);
        }
    }
}
