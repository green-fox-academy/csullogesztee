using ListingTodos2.Models;
using ListingToDos2.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ListingToDos2.Services
{
    public class UserService
    {
        public UserRepository userRepository;

        public UserService(UserRepository userRepository)
        {
            this.userRepository = userRepository;    
        }

        public List<User> ListOfToUsers()
        {
            List<User> ListOfUsers = new List<User>();

            userRepository.toDoContext.ToDos.Load();
            foreach (var user in userRepository.toDoContext.Users)
            {
                ListOfUsers.Add(user);
            }
            return ListOfUsers;
        }

        public User CreateNewUser(string name, string email, int phoneNumber)
        {
            User newUser = new User()
            {
                Name = name,
                Email = email,
                PhoneNumber = phoneNumber
            };
            return newUser;
        }

        public User GetTheUser(string name)
        {
            return userRepository.toDoContext.Users.FirstOrDefault(x => x.Name == name);
        }
    }
}
