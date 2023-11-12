namespace XPDevGames.Domain.Models
{
    public class Comment
    {
        public Comment(string title, string description, string user, int postId)
        {
            Title = title;
            Description = description;
            User = user;
      
            CreateAt = DateTime.Now;
        }

        public int Id { get; private set; }
        public string Title { get; private set; }
        public string Description { get; private set; }
        public string User { get; private set; }
        public DateTime CreateAt { get; private set; }
              
    }
}
