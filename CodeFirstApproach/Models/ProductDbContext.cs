using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstApproach.Models
{
    internal class ProductDbContext :DbContext
    {
        public ProductDbContext()
        {

        }
        public ProductDbContext(DbContextOptions<ProductDbContext> options) 
            : base(options) { }

       
        public DbSet<Product> Products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=ANAMIKA\SQLSERVER;
Initial Catalog=EmpDb;Integrated Security=True;TrustServerCertificate=True");

        }
    }
}
