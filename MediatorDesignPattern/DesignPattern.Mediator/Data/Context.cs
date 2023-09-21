using Microsoft.EntityFrameworkCore;

namespace DesignPattern.Mediator.Data
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = HP\\SQLEXPRESS; Database = DesignPattern.Mediator; Integrated Security = true;");
        }

        public DbSet<Product> Products { get; set; }
    }
}
