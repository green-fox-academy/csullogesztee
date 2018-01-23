using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ListingToDos2.Services
{
    public class LoginService
    {
        public UserService userService;

        public LoginService(UserService userService)
        {
            this.userService = userService;
        }

        public bool CheckUser(string name)
        {     
            return userService.ListOfToUsers().FirstOrDefault(x => x.Name == name) != null;
        }
    }
}