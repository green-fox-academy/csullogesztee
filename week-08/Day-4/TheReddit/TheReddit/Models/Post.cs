using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TheReddit.Models
{
    public class Post
    {
        public long PostId { get; set; }
        public int Score { get; set; }
        public string Date { get; set; } = DateTime.Now.ToString("dd/MM/yyyy");
        public string Content { get; set; }
        public User User { get; set; }
    }
}
