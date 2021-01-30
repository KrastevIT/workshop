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

        public DbSet<Address> Addresses { get; set; }

        public DbSet<PhoneNumber> PhoneNumbers { get; set; }

    }
}
