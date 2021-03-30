using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccountManagement.Domain.RoleAgg;

namespace AccountManagement.Domain.AccountAgg
{
    public class Account
    {
 
        public long Id { get; private set; }
        public string Fullname { get; private set; }
        public string Username { get; private set; }
        public string Password { get; private set; }
        public string Mobile { get; private set; }
        public string ProfilePhoto { get; private set; }
        public DateTime CreataionDate { get; private set; }


        public long RoleId { get; private set; }
        public Role Role { get; private set; }

        public Account(long id, string fullname, string username, string password, string mobile, string profilePhoto, long roleId)
        {
            Id = id;
            Fullname = fullname;
            Username = username;
            Password = password;
            Mobile = mobile;
            ProfilePhoto = profilePhoto;

            if (roleId == 0)
                RoleId = 2;

            CreataionDate = DateTime.Now;

        }


        public void Edit(long id, string fullname, string username, string password, string mobile, string profilePhoto, long roleId)
        {
            Id = id;
            Fullname = fullname;
            Username = username;
            Password = password;
            Mobile = mobile;

            if (!string.IsNullOrWhiteSpace(profilePhoto))
                ProfilePhoto = profilePhoto;

            if (roleId == 0)
                RoleId = 2;
        }

        public void ChangePassword(string password)
        {
            Password = password;
        }
    }
}
