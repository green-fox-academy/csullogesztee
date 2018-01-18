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
    }
}

