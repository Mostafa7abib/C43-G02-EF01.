using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Demo.Entities;
using Microsoft.EntityFrameworkCore;

namespace Demo.Contexts
{
    internal class EnterPriseDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=ABOHABIB\\MSSQLSERVER01;Database=DemoOfEF01;Trusted_Connection=True;TrustServerCertificate=True");
        }
        public DbSet<Employee> Employees { get; set; }
    }
}
