using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ListingTodos2.Models
{
    public class User
    {
        [Key]
        public long? UserId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public int PhoneNumber { get; set; }
        public IList<ToDo> CreatedToDos { get; set; } = new List<ToDo>();
        public IList<ToDo> ToDos { get; set; } = new List<ToDo>();
    }
}