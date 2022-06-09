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
        [ProducesResponseType(typeof(UserLoginResponse), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> checkIfUserExist([FromBody] Users userLoginRequest)
        {
            var result = await _userService.checkUser(userLoginRequest);
            return Ok(result);
        }

        [HttpPost]
        [Route("Add")]
        [ProducesResponseType(typeof(UserLoginResponse), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> addUser([FromBody] Users userLoginRequest)
        {
            var result = await _userService.addUser(userLoginRequest);
            return Ok(result);
        }
    }
}
