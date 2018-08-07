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
        //private DbContext dbContext = DbContextFactory.Create();

        //public Customer Get(string id)
        //{
        //    if (string.IsNullOrWhiteSpace(id))
        //    {
        //        return null;
        //    }

        //    var x = from a in dbContext.Set<Customer>()
        //            where a.Id == id
        //            select a;
        //}

        
    }
}
