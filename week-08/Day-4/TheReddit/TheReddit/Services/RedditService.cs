using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TheReddit.Models;
using TheReddit.Repositories;
using TheReddit.ViewModels;

namespace TheReddit.Services
{
    public class RedditService
    {
        public RedditRepository redditRepository;
        public RedditViewModel redditViewModel;

        public RedditService(RedditRepository redditRepository, RedditViewModel redditViewModel)
        {
            this.redditRepository = redditRepository;
            this.redditViewModel = redditViewModel;
        }

        public Post CreatePost(string content)
        {
            Post newPost = new Post()
            {
                Content = content
            };

            return newPost;
        }

        public List<Post> AllPost()
        {
            List<Post> allPost = new List<Post>();
            foreach (var post in redditRepository.redditContext.Posts)
            {
                allPost.Add(post);
            }
            return allPost;
        }
    }
}
