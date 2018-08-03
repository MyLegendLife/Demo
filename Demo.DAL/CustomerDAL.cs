using Demo.IDAL;
using Demo.Model.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Demo.DAL
{
    public partial class CustomerDAL : BaseDAL<Customer>, ICustomerDAL
    {
        
    }
}
