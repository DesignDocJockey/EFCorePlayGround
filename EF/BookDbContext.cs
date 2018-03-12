using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using EF.Entities;

namespace EF
{
    //https://stackoverflow.com/questions/44430963/is-ef-core-add-migration-supported-from-net-standard-library
    //Each DBContext object maps to to a specific database schema
    //To retrieve the entites, create the DbSet to map to the relevant tables 
    public class BookDbContext: DbContext
    {
        private string ConnectionString;

        public BookDbContext(DbContextOptions<BookDbContext> options) : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
               @"Server=(localdb)\mssqllocaldb;Database=ResourcesDB;Trusted_Connection=True;");
        }

        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }
    }
}
