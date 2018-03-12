using System;
//using EF.DBContexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    //public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<BookDbContext>
    //{
    //    public BookDbContext CreateDbContext(string[] args)
    //    {
    //        //IConfigurationRoot configuration = new ConfigurationBuilder()
    //        //    .SetBasePath(Directory.GetCurrentDirectory())
    //        //    .AddJsonFile("appsettings.json")
    //        //    .Build();

    //        var builder = new DbContextOptionsBuilder<BookDbContext>();

    //        //var connectionString = configuration.GetConnectionString("DefaultConnection");

    //        builder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=ResourcesDB;Trusted_Connection=True;");

    //        return new BookDbContext(builder.Options);
    //    }
    //}
}
