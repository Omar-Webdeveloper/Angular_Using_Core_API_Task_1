using Angular_Using_Core_API.Server.DTOs;
using Angular_Using_Core_API.Server.IDataService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Angular_Using_Core_API.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersControllerUsingTeirArchitecture : ControllerBase
    {
        private readonly IDataServicee _data;

        public UsersControllerUsingTeirArchitecture(IDataServicee data)
        {
            _data = data;
        }
        [HttpGet("AllUsers")]
        public IActionResult Get_Users()
        {
            var AllUsers = _data.Get_Users();
            return Ok(AllUsers);
        }
        [HttpPost("NewUser")]
        public IActionResult AddUser(UserDTOs user)
        {
            var NewUser = _data.AddUser(user);
            return Ok(NewUser);
        }
        [HttpGet("OneUserBasedOnEmail/{Email}")]
        public IActionResult Get_User_BasedOnEmailAndPassword(string Email,string password)
        {
            var User = _data.Get_User_BasedOnEmailAndPassword(Email,password);
            if (User == null)
            {
                return NotFound();
            }
            return Ok(User);
        }





        [HttpGet("OneUserBasednamepassword/{Email}/{Password}")]
        public IActionResult Get_All_Users(string Email, string Password)
        {
            var data = _data.Get_All_Users(Email, Password);
            if (data == null)
            {
                return NotFound();
            }
            else { return Ok(data); }
            
        }




            //sdfsdf








    }
}
