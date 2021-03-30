using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using _0_Framework.Application;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Newtonsoft.Json;


namespace Auth_JWT
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]
    public class PermissionAuthorizeAttr : AuthorizeAttribute, IAuthorizationFilter
    {
        public int Permission { get; set; }

        public PermissionAuthorizeAttr(int permission)
        {
            Permission = permission;
        }

        public void OnAuthorization(AuthorizationFilterContext context)
        {
            //context.HttpContext.User.Identity.

            var ClaimPermissions = context.HttpContext.User.Claims
                .FirstOrDefault(x => x.Type == "Permition")?.Value;


             var accountPermissions = JsonConvert.DeserializeObject<List<int>>(ClaimPermissions);


            bool isAuthorize = false;
            foreach (var item in accountPermissions)
                if (item == Permission)
                    isAuthorize = true;

            if (!isAuthorize)
                context.Result = new JsonResult("UnAuthorize");




        }

    }
}
