using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountManagement.Application.Contracts.Account
{
    public class SetToken
    {
        public long Id { get; set; }
        public string Token { get; set; }

        public SetToken(long id , string token)
        {
            Id = id ;
            Token = token ; 
        }
    }
}
