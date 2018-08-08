using System;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using Demo.Model.Entities;

namespace Demo.Model
{
    public class DemoContext : DbContext
    {
        public virtual DbSet<Record> Records { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }

        public DemoContext() : base("name=DemoConn")
        {
            Database.SetInitializer<DemoContext>(null);
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //base.OnModelCreating(modelBuilder);

            var baseType = typeof(EntityTypeConfiguration<>);
            var mappings = GetType().Assembly.GetTypes().
                Where(x => x.BaseType != null && x.BaseType.Namespace == baseType.Namespace && x.BaseType.Name == baseType.Name)
               .ToList();

            foreach (var mapping in mappings)
            {
                dynamic instance = Activator.CreateInstance(mapping);
                modelBuilder.Configurations.Add(instance);
            }

            //去掉表明复数
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
