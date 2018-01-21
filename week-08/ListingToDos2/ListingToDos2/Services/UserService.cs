using ListingTodos2.Models;
using ListingToDos2.Repositories;
using ListingToDos2.ViewModels;
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
        public ToDoUserViewModel toDoUserViewModel;

        public UserService(UserRepository userRepository, ToDoUserViewModel toDoUserViewModel)
        {
            this.userRepository = userRepository;
            this.toDoUserViewModel = toDoUserViewModel;
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

        public User GetTheUserWithName(string name)
        {
            var currentUser = userRepository.toDoContext.Users.FirstOrDefault(x => x.Name == name);
            return currentUser == null ? CreateNewUser("N/A", "N/A", 0) : currentUser;
        }

        public User GetTheUserWithId(long id)
        {
            var currentUser = userRepository.toDoContext.Users.FirstOrDefault(x => x.UserId == id);
            return currentUser == null ? CreateNewUser("N/A", "N/A", 0) : currentUser;
        }
        
    }
}
