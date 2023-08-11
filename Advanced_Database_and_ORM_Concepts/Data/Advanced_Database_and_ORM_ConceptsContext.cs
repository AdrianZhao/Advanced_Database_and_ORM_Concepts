using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Advanced_Database_and_ORM_Concepts.Models;

namespace Advanced_Database_and_ORM_Concepts.Data
{
    public class Advanced_Database_and_ORM_ConceptsContext : DbContext
    {
        public Advanced_Database_and_ORM_ConceptsContext (DbContextOptions<Advanced_Database_and_ORM_ConceptsContext> options)
            : base(options)
        {
        }

        public DbSet<Course> Course { get; set; } = default!;
        public DbSet<Student> Student { get; set; } = default!;
    }
}
