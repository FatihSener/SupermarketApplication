using System;
using System.Collections.Generic;
using System.Text;
using Market.Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace Market.DataAccess.Concrete.EntityFramework
{
    public class MarketContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"server =DESKTOP-ESE2UT8\SQLEXPRESS; database = Northwind; Trusted_Connection = true");
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
