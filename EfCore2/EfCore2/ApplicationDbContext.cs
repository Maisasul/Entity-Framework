using EfCore2;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfCore2
{
    internal class ApplicationDbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\ProjectModels;Initial Catalog=BookStore;Integrated Security=True;Connect Timeout=30;Encrypt=False;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Fluent api 
            modelBuilder.Entity<Book>()
                .Property(b => b.description)
                .IsRequired();
            modelBuilder.Entity<Post>()
                .Property(b => b.describtion)
                .IsRequired();
            modelBuilder.Entity<Post>()
                .Property(b => b.tag)
                .IsRequired(false);
        }
        public  DbSet<Book> books { set; get; }
        public DbSet<Post> posts { set; get; }

    }
}
#region maisacode
//protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//         => optionsBuilder.UseSqlServer("Data Source=(localdb)\\ProjectModels;Initial Catalog=BookStore;Integrated Security=True;Connect Timeout=30;Encrypt=False;");

//public DbSet<Book> Books { get; set; }
//public DbSet<Post> Posts { get; set; }

//protected override void OnModelCreating(ModelBuilder modelBuilder)
//{
//    modelBuilder.Entity<Book>()
//        .Property(b => b.author)
//        .IsRequired();
//}
#endregion