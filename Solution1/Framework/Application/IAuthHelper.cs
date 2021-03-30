using System.Collections.Generic;
using System.Security.Claims;

namespace _0_Framework.Application
{
    public interface IAuthHelper
    {
        string Signin(AuthViewModel account);

        public List<Claim> GetInfo();

        public bool IsAuthenticated();

        public List<int> GetPermissions() ;

    }
}
