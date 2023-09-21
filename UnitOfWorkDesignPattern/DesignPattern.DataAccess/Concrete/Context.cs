using DesignPattern.Entity.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.DataAccess.Concrete
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = HP\\SQLEXPRESS; Database = DesignPattern.UnitOfWork; Integrated Security = true;");
        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Process> Processes { get; set; }
    }
}
