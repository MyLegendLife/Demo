using System.Data.Entity;
using Demo.Model.Entities;

namespace Demo.Model
{
    public class DemoContext : DbContext
    {
        public DemoContext() : base("name=DemoConn")
        {

        }

        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Record> Records { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            

            base.OnModelCreating(modelBuilder);
        }
    }
}
