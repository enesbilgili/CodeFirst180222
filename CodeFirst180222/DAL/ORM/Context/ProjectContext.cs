using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;


namespace CodeFirst180222.DAL.ORM.Context
{

    /*
     1# NuGet Package Manager ile Entity Framework proje eklenir 
    2# ORM Klasörü alında -> Context ve Entity Klasörleri oluşturulur
    3#Entity klasörü altına tablo olcak olan class'lar yazılır.
    4#Context klasörü altında "ProjectContext" gibi bir isim verilerek context class'ı açılır .
     */
    class ProjectContext : DbContext
    {
        public ProjectContext() 
        {
            Database.Connection.ConnectionString = "SERVER=(LocalDb)\\MSSQLLocalDB;DATABASE=ProjectContext;UID=sa;PWD=Password01";
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
       // public DbSet<AppUser> AppUsers { get; set; }

    }
}
