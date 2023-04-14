using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class CustomerContext :DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder contextOptionsBuilder)
        {
            contextOptionsBuilder.UseSqlServer(
                @"Server=EMRE;
                  Database=Tech4Pay;
                  TrustServerCertificate=True;
                  Trusted_Connection = true");

        }

       public DbSet<Customer> Customers { get; set; }
    }
}
