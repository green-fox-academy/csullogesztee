using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TheReddit.Entities;
using TheReddit.Models;

namespace TheReddit.Repositories
{
    public class RedditRepository
    {
        public RedditContext redditContext;

        public RedditRepository(RedditContext redditContext)
        {
            this.redditContext = redditContext;
        }

        public void AddNewPost(Post post)
        {
            redditContext.Add(post);
            redditContext.SaveChanges();
        }

        public void IncreaseScore(long id)
        {

            var updatedPost = redditContext.Posts.Where(p => p.PostId == id).FirstOrDefault();

            updatedPost.Score++;

            redditContext.SaveChanges();
        }

        public void DecreaseScore(long id)
        {

            var updatedPost = redditContext.Posts.Where(p => p.PostId == id).FirstOrDefault();

            updatedPost.Score--;

            redditContext.SaveChanges();
        }

        public void DeletePost(Post post)
        {
            redditContext.Remove(post);
            redditContext.SaveChanges();
        }
    }
}
