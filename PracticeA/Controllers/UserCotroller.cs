using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using MongoDB.Driver;
using PracticeA.Applications;
using PracticeA.Models;
using System.Collections.Generic;

namespace PracticeA.Controllers
{       [ApiController]
        [Route("[controller]")]
    public class UserCotroller : ControllerBase
    {
        UserService userService;

        public UserCotroller(UserService _userService)
        {
            userService = _userService;
        }

        [HttpGet]
        public ActionResult<List<Users>> GetAllUsers()
        {
            
            return userService.GetAllUsers();
        }

        [HttpGet("{id:int}")]
        public ActionResult<Users> GetUser(int id)
        {
            return userService.GetUser(id);
        }

        [HttpPost]

        public ActionResult<Users> SetUser(Users user)
        {
            userService.SetUsers(user);
            return StatusCode(200);
        }
        [HttpPut("{id:int}")]

        public ActionResult<Users> UpdateUser(int id,Users user)
        {
            userService.UpdateUser(id,user);
            return StatusCode(200);
        }

        [HttpDelete("{id:int}")]

        public ActionResult<Users> DeleteUser(int id)
        {
            userService.DeleteUser(id);
            return StatusCode(200);
        }
    }
}
