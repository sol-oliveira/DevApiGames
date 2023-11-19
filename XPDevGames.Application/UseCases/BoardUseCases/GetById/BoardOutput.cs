namespace XPDevGames.Application.UseCases.BoardUseCases.GetById
{
    public class BoardOutput
    {
        public string GameTitle { get; set; }
        public DateTime CreatedAt { get; set; }
        public string Description { get; set; }
        public string Rules { get; set; }


        public BoardOutput(string gameTitle, string description, string rules, DateTime created_at)
        {
            GameTitle = gameTitle;
            Description = description;
            Rules = rules;
            CreatedAt = created_at;
        }
    }
}
