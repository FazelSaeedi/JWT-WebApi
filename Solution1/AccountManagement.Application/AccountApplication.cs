using System.Collections.Generic;
using _0_Framework.Application;
using AccountManagement.Application.Contracts.Account;


namespace AccountManagement.Application
{
    public class AccountApplication : IAccountApplication
    {
        public AccountViewModel GetAccountBy(long id)
        {
            throw new System.NotImplementedException();
        }

        public OperationResult Register(RegisterAccount command)
        {
            throw new System.NotImplementedException();
        }

        public OperationResult Edit(EditAccount command)
        {
            throw new System.NotImplementedException();
        }

        public OperationResult ChangePassword(ChangePassword command)
        {
            throw new System.NotImplementedException();
        }

        public OperationResult Login(Login command)
        {
            throw new System.NotImplementedException();
        }

        public EditAccount GetDetails(long id)
        {
            throw new System.NotImplementedException();
        }

        public void Logout()
        {
            throw new System.NotImplementedException();
        }

        public List<AccountViewModel> GetAccounts()
        {
            throw new System.NotImplementedException();
        }
    }
}