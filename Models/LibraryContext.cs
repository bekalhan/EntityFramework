using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace EFCore.Models
{
    public class LibraryContext : DbContext
	{
        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=localhost,1433;Database=Crud;User=SA;Password=MyPassword123#;Trusted_Connection=false;Encrypt=false;");
        }
    }
}

