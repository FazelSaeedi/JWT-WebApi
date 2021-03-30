using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using AccountManagement.Application.Contracts.Account;
using AccountManagement.Domain.AccountAgg;

namespace AccountMangement.Infrastructure.EFCore.Repository
{
    public class AccountRepository : IAccountRepository
    {
        private readonly AccountContext _context;

        public AccountRepository(AccountContext context)
        {
            _context = context;
        }

        public long Get(Account id)
        {
            throw new NotImplementedException();
        }

        public List<long> Get()
        {
            throw new NotImplementedException();
        }

        public void Create(Account entity)
        {
            _context.Add(entity);
        }

        public bool Exists(Func<Account, bool> expression)
        {
            return _context.Set<Account>().Any(expression);
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }

        public Account GetBy(string username)
        {
            return _context.Accounts.FirstOrDefault(x => x.Username == username);
        }

        public EditAccount GetDetails(long id)
        {
            throw new NotImplementedException();
        }

        public List<AccountViewModel> GetAccounts()
        {
            throw new NotImplementedException();
        }
    }
}
