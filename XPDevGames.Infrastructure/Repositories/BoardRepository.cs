using Dapper;
using System.Data;
using System.Data.SqlClient;
using XPDevGames.Domain.Models;

namespace XPDevGames.Infrastructure.Repositories
{
    public class BoardRepository
    {
        private const string connectionString = "";
          
         public List<Board> GetAll()
         {
            var sql = "SELECT GAME_TITLE AS GameTitle, DESCRIPTION, RULES, CREATED_AT FROM BOARD";

            using IDbConnection connection = new SqlConnection(connectionString);

            var board = connection.Query<Board>(sql);

            return board.ToList();
         }


        public Board GetById(int id)
        {
            var sql = "SELECT ID, GAME_TITLE AS GameTitle, DESCRIPTION, RULES, CREATED_AT FROM BOARD WHERE ID = @id";

            using IDbConnection connection = new SqlConnection(connectionString);

            var board = connection.QueryFirstOrDefault<Board>(sql, new { ID = id });

            return board;
        }

        public void Add(Board board)
        {
            var sql = $"INSERT INTO BOARD (GAME_TITLE, DESCRIPTION, RULES, CREATED_AT) VALUES ('{board.GameTitle}', '{board.Description}', '{board.Rules}', CURRENT_TIMESTAMP )";

            
            using IDbConnection connection = new SqlConnection(connectionString);

            connection.Execute(sql);
        }
    }
}
