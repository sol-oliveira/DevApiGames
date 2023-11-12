using XPDevGames.Domain.Models;

namespace XPDevGames.Infrastructure.Repositories
{
    public class BoardRepository
    {
        public Board Get()
        {
            Board obj = new Board("Termo", "o jogo termo tem como objetivo adivinhação de palavras", "Não pode  passar  de  06 palavras");
            return obj;
        }
    }
}
