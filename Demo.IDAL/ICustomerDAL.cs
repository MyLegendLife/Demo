using System;
using System.Threading.Tasks;
using Demo.Model.Entities;

namespace Demo.IDAL
{
    public partial interface ICustomerDAL : IBaseDAL<Customer>
    {
        Customer Get(Guid id);
        int GetLevel(Guid id);
        Task<Customer> GetAsync(Guid id);
    }
}
