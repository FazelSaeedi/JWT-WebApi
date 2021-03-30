using _0_Framework.Application;
using AccountManagement.Application.Contracts.Role;
using System.Collections.Generic;

namespace AccountManagement.Application
{
    public class RoleApplication : IRoleApplication
    {
        public OperationResult Create(CreateRole command)
        {
            throw new System.NotImplementedException();
        }

        public OperationResult Edit(EditRole command)
        {
            throw new System.NotImplementedException();
        }

        public List<RoleViewModel> List()
        {
            throw new System.NotImplementedException();
        }

        public EditRole GetDetails(long id)
        {
            throw new System.NotImplementedException();
        }
    }
}