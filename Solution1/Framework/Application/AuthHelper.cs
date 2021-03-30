using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Authentication;
using Microsoft.IdentityModel.Tokens;
using Newtonsoft.Json;
using AuthenticationProperties = Microsoft.AspNetCore.Http.Authentication.AuthenticationProperties;

namespace _0_Framework.Application
{
    public class AuthHelper : IAuthHelper
    {
        private readonly IHttpContextAccessor _contextAccessor;

        public AuthHelper(IHttpContextAccessor contextAccessor)
        {
            _contextAccessor = contextAccessor;
        }

        public string Signin(AuthViewModel account)
        {

            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes("MY_BIG_SECRET_KEY_ASDWQEWEWWEQ@#@!#!@#QWE!@!#!@#!@#!@EWQE!@#!@#!@#QWE!@#!@#@!LKSHDJFLSDKFW@#($)(#)32234");

            //var permissions = JsonConvert.SerializeObject(new List<int>(){1 , 3});
            var permissions = JsonConvert.SerializeObject(account.Permissions);


            var claims = new List<Claim>
            {
                new Claim("Fullname" , account.Fullname),
                new Claim("Mobile" , account.Mobile),
                new Claim("Username" , account.Username),
                new Claim("AccountId" , account.Id.ToString()),
                new Claim("Permition" , permissions),
                new Claim(ClaimTypes.Role , account.RoleId.ToString()),
            };


            var tokenDescription = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(claims),
                Expires = DateTime.UtcNow.AddSeconds(10),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };

            var token = tokenHandler.CreateToken(tokenDescription);
            var tokenString = tokenHandler.WriteToken(token);

            return tokenString ;
        }

        public List<Claim> GetInfo()
        {
            return _contextAccessor.HttpContext.User.Claims.ToList();
        }

        public bool IsAuthenticated()
        {
            return _contextAccessor.HttpContext.User.Identity.IsAuthenticated;
        }

        public List<int> GetPermissions()
        {
            throw new NotImplementedException();
        }
    }
}