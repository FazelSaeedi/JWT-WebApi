using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using AccountManagement.Application.Contracts.Role;
using AccountManagement.Domain.RoleAgg;

namespace AccountMangement.Infrastructure.EFCore.Repository
{
    public class RoleRepository : IRoleRepository
    {
        private readonly AccountContext _context;

        public RoleRepository(AccountContext context)
        {
            _context = context;
        }


        public Role Get(long id)
        {
            return _context.Find<Role>(id);
        }

        public List<long> Get()
        {
            throw new NotImplementedException();
        }

        public void Create(long entity)
        {
            throw new NotImplementedException();
        }

        public bool Exists(Expression<Func<long, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public void SaveChanges()
        {
            throw new NotImplementedException();
        }

        public List<RoleViewModel> List()
        {
            throw new NotImplementedException();
        }

        public EditRole GetDetails(long id)
        {
            throw new NotImplementedException();
        }
    }
}
