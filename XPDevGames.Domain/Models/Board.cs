namespace XPDevGames.Domain.Models
{
    public class Board
    {
        public int Id { get; set; }
        public string GameTitle { get; set; }
        public string Description { get; set; }
        public string Rules { get; set; }
        public DateTime CreatedAt { get; set; }
               
       
        public Board(string gameTitle, string description, string rules, DateTime created_at)
        {         
            GameTitle = gameTitle;
            Description = description;
            Rules = rules;
            CreatedAt = created_at;
        }
       
    }
}
