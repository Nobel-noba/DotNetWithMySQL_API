using Microsoft.AspNetCore.Mvc;
using PracticeA.Applications;
using PracticeA.Models;
using System.Collections.Generic;

namespace PracticeA.Controllers
{       [ApiController]
        [Route("api/users")]
    public class UserCotroller : ControllerBase
    {
        UserService userService = new UserService();

        [HttpGet]
        public ActionResult<List<Users>> GetAllUsers()
        {
            
            return userService.GetAllUsers();
        }
    }
}
