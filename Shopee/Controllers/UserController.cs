using Microsoft.AspNetCore.Mvc;
using Shopee.Services;
using Shopee.Models;
using System.Net;

namespace Shopee.Controllers
{
    [Route("User")]
    public class UserController : Controller
    {
        private IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpPost]
        [Route("Check")]
        [ProducesResponseType(typeof(RequestResponse), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> checkIfUserExist([FromBody] UserLoginRequest userLoginRequest)
        {
            var result = await _userService.checkUser(userLoginRequest);
            return Ok(result);
        }

        [HttpPost]
        [Route("Add")]
        [ProducesResponseType(typeof(RequestResponse), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> addUser([FromBody] AddUserRequest addUserRequest)
        {
            var result = await _userService.addUser(addUserRequest);
            return Ok(result);
        }
    }
}
