using Reddit.Entities;
using Reddit.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Reddit.Repositories
{
    public class RedditRepository
    {
        public RedditContext redditContext;

        public RedditRepository(RedditContext redditContext)
        {
            this.redditContext = redditContext;
        }

        public List<Post> GetPosts()
        {
            return redditContext.Reddit.ToList();
        }

        public Post AddPost(PostCreator postCreator)
        {
            Post Post = new Post()
            {
                Title = postCreator.Title,
                Url = postCreator.Url
            };

            redditContext.Reddit.Add(Post);
            redditContext.SaveChanges();

            return Post;
        }
    }
}
