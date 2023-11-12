using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XPDevGames.Domain.Models
{
    public class Board
    {
        public Board(string gameTitle, string description, string rules)
        {

            GameTitle = gameTitle;
            Description = description;
            Rules = rules;

            CreatedAt = DateTime.Now;

        }

        public int Id { get; set; }
        public string GameTitle { get; set; }
        public string Description { get; set; }
        public string Rules { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
