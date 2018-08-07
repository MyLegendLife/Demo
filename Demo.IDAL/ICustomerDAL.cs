using System;
using Demo.Model.Entities;

namespace Demo.IDAL
{
    public partial interface ICustomerDAL : IBaseDAL<Customer>
    {
        //Customer Get(Guid id);

        Customer Get(Guid id);
    }
}
