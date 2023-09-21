using Microsoft.EntityFrameworkCore;

namespace DesignPattern.ChainOfResponsibility.DataAccess
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = HP\\SQLEXPRESS; Database = DesignPattern.ChainOfResponsibility; Integrated Security = true;");
        }

        public DbSet<CustomerProcess> CustomerProcesses { get; set; }
    }
}
