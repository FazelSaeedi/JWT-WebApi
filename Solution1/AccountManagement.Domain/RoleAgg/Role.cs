using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccountManagement.Domain.AccountAgg;

namespace AccountManagement.Domain.RoleAgg
{
    public class Role
    {
        public long Id { get; private set; }
        public string Name { get; private set; }
        public List<Permission> Permissions { get; private set; }
        public List<Account> Accounts { get; private set; }


        public DateTime CreataionDate { get; private set; }


        protected Role()
        {
        }

        public Role(string name, List<Permission> permissions )
        {
            Name = name;
            Permissions = permissions;
            Accounts = new List<Account>();
            CreataionDate = DateTime.Now;
        }

        public void Edit(string name, List<Permission> permissions)
        {
            Name = name;
            Permissions = permissions;
        }
    }
}
