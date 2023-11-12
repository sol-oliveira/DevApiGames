using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XPDevGames.Domain.Models;

namespace XPDevGames.Infrastructure.Repositories
{
    public class PostRepository
    {
        public Post Get() {

           var post = new Post("titulo de teste", "description de teste", 1);

            return post;
        }
        
    }
}
