using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using AccountManagement.Application.Contracts.Account;

namespace AccountManagement.Domain.AccountAgg
{
    public interface IAccountRepository 
    {
        long Get(Account id);
        List<long> Get();
        void Create(Account entity);
        bool Exists(Func<Account, bool> expression);
        void SaveChanges();


        Account GetBy(string username);
        EditAccount GetDetails(long id);
        List<AccountViewModel> GetAccounts();
    }
}
