using Reddit.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Reddit.Services
{
    public class RedditService
    {
        public RedditRepository redditRepository;

        public RedditService(RedditRepository redditRepository)
        {
            this.redditRepository = redditRepository;
        }
    }
}
