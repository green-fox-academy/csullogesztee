using FilmSelector.Models;
using FilmSelector.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FilmSelector.Services
{
    public class UserService
    {
        private UserRepository userRepository;

        public UserService(UserRepository userRepository)
        {
            this.userRepository = userRepository;
        }

        public List<User> ListOfUsers()
        {
            return userRepository.AllUser();
        }

        public User GetUserWithName(string name)
        {
            return userRepository.GetUserWithName(name);
        }
    }
}
