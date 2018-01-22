using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TheReddit.Models;

namespace TheReddit.ViewModels
{
    public class RedditViewModel
    {
        public List<Post> allPost = new List<Post>();
        public List<Post> top10 = new List<Post>();
        public List<Post> otherPosts = new List<Post>();

        public List<Post> Top10()
        {
            var sortedList = allPost.OrderBy(p => p.Score).ToList();

            if (allPost.Count() <= 10)
            {
                for (int i = 0; i < allPost.Count(); i++)
                {
                    top10.Add(sortedList[i]);
                }
            }
            return top10;
        }

        public List<Post> OtherPosts()
        {
            var sortedList = allPost.OrderBy(p => p.Score).ToList();

            if (allPost.Count() > 10)
            {
                for (int i = 10; i < allPost.Count(); i++)
                {
                    otherPosts.Add(sortedList[i]);
                }
            }
            return otherPosts;
        }
    }
}
