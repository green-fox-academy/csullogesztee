using ListingTodos2.Entities;
using ListingTodos2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ListingToDos2.Repositories
{
    public class UserRepository
    {
        public TodoContext toDoContext;

        public UserRepository(TodoContext toDoContext)
        {
            this.toDoContext = toDoContext;
        }

        public void AddNewUser(User user)
        {
            toDoContext.Users.Add(user);
            toDoContext.SaveChanges();
        }

        public void DeleteUser(long id)
        {
            foreach (var user in toDoContext.Users)
            {
                if (user.UserId == id)
                {
                    if(user.ToDos.Count() == 0 && user.CreatedToDos.Count() == 0)
                    toDoContext.Remove(user);
                }
            }
            toDoContext.SaveChanges();
        }

        public void EditUser(User user, long id)
        {
            var userToUpdate = toDoContext.Users.Where(t => t.UserId == id).FirstOrDefault();

            userToUpdate.Name = user.Name;
            userToUpdate.Email = user.Email;
            userToUpdate.PhoneNumber = user.PhoneNumber;

            toDoContext.SaveChanges();
        }
    }
}

