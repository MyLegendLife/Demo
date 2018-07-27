using Demo.DAL.Entities.User;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.DAL
{
    public class DemoContext : DbContext
    {
        public DemoContext() : base("name=DemoConn")
        {

        }

        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Record> Records { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            

            base.OnModelCreating(modelBuilder);
        }
    }
}
