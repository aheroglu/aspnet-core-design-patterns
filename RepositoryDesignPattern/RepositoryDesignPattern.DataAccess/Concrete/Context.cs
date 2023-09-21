using Microsoft.EntityFrameworkCore;
using RepositoryDesignPattern.Entity.Concrete;

namespace RepositoryDesignPattern.DataAccess.Concrete
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = HP\\SQLEXPRESS; Database = DesignPattern.Repository; Integrated Security = true;");
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}
