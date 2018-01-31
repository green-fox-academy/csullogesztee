using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FilmSelector.Services
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
            return userService.ListOfUsers().Single(x => x.Name == name) != null;
        }
    }
}
