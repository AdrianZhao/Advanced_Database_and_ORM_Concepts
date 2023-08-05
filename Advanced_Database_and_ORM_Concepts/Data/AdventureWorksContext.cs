using Advanced_Database_and_ORM_Concepts.Models;
using Microsoft.EntityFrameworkCore;
namespace Advanced_Database_and_ORM_Concepts.Data
{
    public class AdventureWorksContext: DbContext
    {
        public AdventureWorksContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Customer> Customer { get; set; } = null!;
        public DbSet<Address> Address { get; set; } = null!;
    }
}
