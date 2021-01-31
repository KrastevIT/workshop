using CustomerInformation.Data.Models;
using System.Data.Entity;

namespace CustomerInformation.Data
{
    public class CustomerInformationContext : DbContext
    {
        public CustomerInformationContext()
        {

        }

        public DbSet<Customer> Customers { get; set; }

        public DbSet<HomeAddress> HomeAddresses { get; set; }

        public DbSet<OfficeAddress> OfficeAddresses { get; set; }

        public DbSet<HomePhone> HomePhones { get; set; }

        public DbSet<OfficePhone> OfficePhones { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>()
                .HasMany(x => x.OfficeAddresses)
                .WithRequired(x => x.Customer)
                .HasForeignKey(x => x.CustomerId)
                .WillCascadeOnDelete(false);


            modelBuilder.Entity<Customer>()
                 .HasMany(x => x.HomeAddresses)
                 .WithRequired(x => x.Customer)
                 .WillCascadeOnDelete(false);

            //modelBuilder.Entity<OfficeAddress>()
            //    .HasRequired(x => x.Customer)
            //    .WithMany()
            //    .WillCascadeOnDelete(false);


            base.OnModelCreating(modelBuilder);
        }

    }
}
