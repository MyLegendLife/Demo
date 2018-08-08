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
        private DbContext dbContext = DbContextFactory.Create();

        public Customer Get(Guid id)
        {
            return dbContext.Set<Customer>().Where(a => a.Id == id).FirstOrDefault();
        }

        public int GetLevel(Guid id)
        {
            var query = dbContext.Set<Customer>();

            var ret = from a in query
                      where a.Id == id
                      select a.Level;

            return ret.Count() > 0 ? ret.FirstOrDefault() : -1;
        }

        public async Task<Customer> GetAsync(Guid id)
        {
            return await dbContext.Set<Customer>().FindAsync(id);
        }
    }
}
