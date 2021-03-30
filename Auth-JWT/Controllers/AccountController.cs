using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Web.Helpers;
using _0_Framework.Application;
using AccountManagement.Application.Contracts.Account;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.Filters;

namespace Auth_JWT.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly IAccountApplication _accountApplication;
        private readonly IAuthHelper _authHelper;

        public AccountController(IAccountApplication accountApplication, IAuthHelper authHelper)
        {
            _accountApplication = accountApplication;
            _authHelper = authHelper;
        }


        [PermissionAuthorizeAttr(3)]
        [HttpGet("AccountTest")]
        public IActionResult AccountControllerTest()
        {
            var claims = _authHelper.GetInfo();
            return Ok();
        }




        [HttpPost("register")]
        public IActionResult Register(RegisterAccount command)
        {
            var result = _accountApplication.Register(command);
            return Ok(result.IsSuccedded);
        }




        [AllowAnonymous]
        [HttpPost("login")]
        public IActionResult Login(Login command)
        {
            var result = _accountApplication.Login(command);

            if (result.IsSuccedded)
                return Ok(result.Message);
            else
                return StatusCode(200, "Your information is invalid");

        }
    }


}
