using System.Collections.Generic;
using AdvancedDatabaseAndORMConcepts.Models;
using Microsoft.EntityFrameworkCore;

namespace Advanced_Database_and_ORM_Concepts.Data
{
    public class AdvancedDatabaseAndORMConceptsLab04Context : DbContext
    {
        public AdvancedDatabaseAndORMConceptsLab04Context(DbContextOptions options)
                : base(options)
        {
        }

        public DbSet<Client> Clients { get; set; } = default!;
        public DbSet<Room> Rooms { get; set; } = default!;
    }
}
