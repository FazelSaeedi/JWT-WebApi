using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AccountManagement.Application.Contracts.Account;

namespace Auth_JWT.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly IAccountApplication _accountApplication;

        public AccountController(IAccountApplication accountApplication)
        {
            _accountApplication = accountApplication;
        }

        [HttpGet("AccountTest")]
        public IActionResult AccountControllerTest()
        {
            return Ok();
        }

        [HttpPost("register")]
        public IActionResult Register(RegisterAccount command)
        {
            var result = _accountApplication.Register(command);
            return Ok(result.IsSuccedded);
        }

        [HttpPost("login")]
        public IActionResult Login(Login command)
        {
            var result = _accountApplication.Login(command);

            return Ok(result.IsSuccedded);
        }
    }
}
