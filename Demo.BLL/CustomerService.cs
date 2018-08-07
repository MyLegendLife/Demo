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
        private ICustomerDAL CustomerDAL = DALContainer.Container.Resolve<ICustomerDAL>();

        public override void SetDal()
        {
            Dal = CustomerDAL;
        }

        public Customer Get(Guid id)
        {
            return CustomerDAL.Get(id);
        }
    }
}
