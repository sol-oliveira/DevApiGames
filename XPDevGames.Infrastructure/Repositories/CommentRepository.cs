using XPDevGames.Domain.Models;

namespace XPDevGames.Infrastructure.Repositories
{
    public class CommentRepository
    {
        public Comment Get() {

            Comment obj = new Comment("titulo de comment", "description de comment", "user de  comment", 1);

            return obj;
        }
    }
}
