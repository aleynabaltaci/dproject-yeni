using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dproject_yeni
{
    public class dbprojeContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"server=(localdb)\mssqllocaldb;database=Ecommerce;Trusted_Connection=true;");
        }
        public DbSet<Araba> Arabalar { get; set; }
    }
}
