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
            var user = new User() { Name = postCreator.Owner };

            if(redditContext.Users.Any(x=> x.Name == postCreator.Owner))
            {
                user = redditContext.Users.First(x => x.Name == postCreator.Owner);
            }
            redditContext.SaveChanges();

            Post post = new Post()
            {
                Title = postCreator.Title,
                Url = postCreator.Url,
                Owner = user
            };

            user.PostsOfTheUser.Add(post);

            redditContext.Reddit.Add(post);
            redditContext.SaveChanges();

            return post;
        }

        public bool ValidId(long id)
        {
            return redditContext.Reddit.Where(x => x.Id == id).Count() > 0;
        }

        public User FindUser(string name)
        {
            return redditContext.Users.FirstOrDefault(x => x.Name == name);
        }

        public void UpVote(long id, string userName)
        {
            var user = FindUser(userName);
            var post = redditContext.Reddit.FirstOrDefault(x => x.Id == id);

            if(!post.Likes.Any(x=>x.Name == userName))
            {
                post.Likes.Add(user);
                post.Score++;
                redditContext.SaveChanges();
            }

        }

        public void DownVote(long id, string userName)
        {
            var user = FindUser(userName);
            var post = redditContext.Reddit.FirstOrDefault(x => x.Id == id);

            if (!post.Likes.Any(x => x.Name == userName))
            {
                post.Likes.Add(user);
                post.Score--;
                redditContext.SaveChanges();
            }
        }

        public List<User> GetUser()
        {
            return redditContext.Users.ToList();
        }
    }
}
