using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using System;

namespace EF
{
    //https://www.dustinhorne.com/post/2017/10/27/deeper-dive-into-ef-core-2-part-1
    /*
    Helpful Commands:
    sqllocaldb - lists all the local running db instances
    sqllocaldb info [name of db] returns info about the database

    #1 - Install the following EntityFrameworkCore NuGet packages
    NuGet Packages via Package Manager Console:
    Install-Package Microsoft.EntityFrameworkCore -Version 2.0.1
    Install-Package Microsoft.EntityFrameworkCore.SqlServer -Version 2.0.1
    Install-Package Microsoft.EntityFrameworkCore.Tools -Version 2.0.1
     
    #2 - Retrieve the Connection String: 
    Data Source = (localdb)\MSSQLLocalDB;Initial Catalog = master; Integrated Security = True; Connect Timeout = 30; Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False

    #3 - Create Model Entities
    #4 - Create a Context object 

    #5 - Do Migrations
    On the executable project, add the NuGet reference:
    Install-Package Microsoft.EntityFrameworkCore.Design -Version 2.0.1

    Select the Project that is an executable project in the Package Manager Console; 
    run: 
    get-help entityframeworkcore -- to retrieve the help

    run: 
    add-migration initial

    */
    //https://codingblast.com/entityframework-core-idesigntimedbcontextfactory/
    //public class TemporaryDbContextFactory : IDbContextFactory<BookDbContext>
    //{
    //    public BookDbContext Create(DbContextFactoryOptions options)
    //    {
    //        var builder = new DbContextOptionsBuilder<BookDbContext>();
    //        builder.UseSqlServer(@"Server = (localdb)\mssqllocaldb; Database = ResourcesDB; Trusted_Connection = True;",
    //            optionsBuilder => optionsBuilder.MigrationsAssembly(typeof(BookDbContext).GetTypeInfo().Assembly.GetName().Name));
    //        return new BookDbContext(builder.Options);
    //    }
    //}
}

