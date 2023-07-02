using EFC3.Moduls;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFC3
{
    public class ApplicationDbConnection:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\ProjectModels;Initial Catalog=MinBlog;Integrated Security=True;Connect Timeout=30;Encrypt=False;");
        }
        DbSet<Blog> blogs {  get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Blog>()
                .HasOne(a => a.author)
                .WithOne(b => b.Blog)
                .HasForeignKey<Blog>(a => a.AuthorId);

            modelBuilder.Entity<Post>()
                .HasMany(p => p.tags)
                .WithMany(p => p.posts);

        }
    }
}
