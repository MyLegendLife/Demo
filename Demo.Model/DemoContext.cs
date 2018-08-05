using System;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration;
using System.Data.Entity.ModelConfiguration.Conventions;
using Demo.Model.Entities;

namespace Demo.Model
{
    public class DemoContext : DbContext
    {
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Record> Records { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }

        public DemoContext() : base("name=DemoConn")
        {
            Database.SetInitializer<DemoContext>(null);
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //var mappings = GetType().Assembly.GetInheritedTypes(typeof(EntityTypeConfiguration<>));
            //foreach (var mapping in mappings)
            //{
            //    dynamic instance = Activator.CreateInstance(mapping);
            //    modelBuilder.Configurations.Add(instance);
            //}

            //去掉表明复数
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
