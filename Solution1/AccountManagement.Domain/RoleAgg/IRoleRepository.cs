using System;
using AccountManagement.Application.Contracts.Role;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace AccountManagement.Domain.RoleAgg
{
    public interface IRoleRepository 
    {
        Role Get(long id);
        List<long> Get();
        void Create(long entity);
        bool Exists(Expression<Func<long, bool>> expression);
        void SaveChanges();


        List<RoleViewModel> List();
        EditRole GetDetails(long id);
    }
}
