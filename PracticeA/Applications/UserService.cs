using PracticeA.Models;
using System.Collections.Generic;

namespace PracticeA.Applications
{
    public class UserService
    {
        public List<Users> GetAllUsers()
        {
            return new List<Users>() { new Users() { Id = 123, name = "Jone" }, new Users { Id = 321, name = "kiya" } };
        }
    }
}
