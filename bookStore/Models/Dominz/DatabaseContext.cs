using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace bookStore.Models.Dominz
{
    public class DatabaseContext : DbContext
    {

            public DatabaseContext(DbContextOptions<DatabaseContext>options):base(options)
            {
                
            }

            public DbSet<Genre> Genre { get; set; }
            public DbSet<Author> Author { get; set; }
            public DbSet<Publisher> Publisher { get; set; }
            public DbSet<Book> Book { get; set; }

         

    }
}
