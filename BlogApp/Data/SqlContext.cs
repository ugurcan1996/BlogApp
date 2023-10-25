using BlogApp.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;

namespace BlogApp.Data
{
    public class SqlContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<Blog> Blogs { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-FR8E4M9\\SQLEXPRESS;Database=BlogAppDB;Trusted_Connection=True;");

            base.OnConfiguring(optionsBuilder);
        }
    }
}
