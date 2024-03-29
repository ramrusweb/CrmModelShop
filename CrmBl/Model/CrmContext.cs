﻿using System.Data.Entity;

namespace CrmBl.Model
{
    public class CrmContext : DbContext
    {
        /// <summary>
        /// This class contains the database context.
        /// </summary>
        public CrmContext() : base("CrmConnection") { }

        public DbSet<Check> Checks { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Sell> Sells { get; set; }
        public DbSet<Seller> Sellers { get; set; }
    }
}
