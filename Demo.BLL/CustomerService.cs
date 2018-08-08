using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Demo.IBLL;
using Demo.IDAL;
using Demo.Model.Entities;

namespace Demo.BLL
{
    public partial class CustomerService : BaseService<Customer>, ICustomerService
    {
        private ICustomerDAL customerDAL = DALContainer.Container.Resolve<ICustomerDAL>();

        public override void SetDal()
        {
            Dal = customerDAL;
        }

        public Customer Get(Guid id)
        {
            return customerDAL.Get(id);
        }

        public int GetLevel(Guid id)
        {
            return customerDAL.GetLevel(id);
        }

        public Task<Customer> GetAsync(Guid id)
        {
            return customerDAL.GetAsync(id);
        }
    }
}
