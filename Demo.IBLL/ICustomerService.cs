using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Demo.Model.Entities;

namespace Demo.IBLL
{
    public partial interface ICustomerService : IBaseService<Customer>
    {
        Customer Get(Guid id);
        int GetLevel(Guid id);
        Task<Customer> GetAsync(Guid id);
    }
}
