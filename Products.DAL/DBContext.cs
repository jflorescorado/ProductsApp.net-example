using System;
using System.Collections.Generic;
using System.Text;

// Imports 
using Microsoft.EntityFrameworkCore;
using Products.Entities;

namespace Products.DAL
{
    public class DBContext: DbContext
    {
        public DbSet<Product> Product { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=M09-CI\SQLEXPRESS;Initial Catalog=ProductsApp;Integrated Security=True");
        }
    }
}
