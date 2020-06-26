using System;
using System.Collections.Generic;

namespace CrmBl.Model
{
    public class Generator
    {
        /// <summary>
        /// This class generates Customers.
        /// </summary>

        Random rnd = new Random();

        public List<Customer> Customers { get; set; } = new List<Customer>();
        public List<Product> Products { get; set; } = new List<Product>();
        public List<Seller> Sellers { get; set; } = new List<Seller>();

        // Customer generator.
        public List<Customer> GetNewCustomers(int count)
        {
            var result = new List<Customer>();

            for (int i = 0; i < count; i++)
            {
                var customer = new Customer()
                {
                    CustomerId = Customers.Count,
                    Name = GetRandomText()
                };
                Customers.Add(customer); // TODO:
                result.Add(customer);
            }
            return result;
        }

        // Sellers generator.
        public List<Seller> GetNewSellers(int count)
        {
            var result = new List<Seller>();

            for (int i = 0; i < count; i++)
            {
                var seller = new Seller()
                {
                    SellerId = Sellers.Count,
                    Name = GetRandomText()
                };
                Sellers.Add(seller); // TODO:
                result.Add(seller);
            }
            return result;
        }

        // Product generator.
        public List<Product> GetNewProducts(int count)
        {
            var result = new List<Product>();

            for (int i = 0; i < count; i++)
            {
                var product = new Product()
                {
                    ProductId = Products.Count,
                    Name = GetRandomText(),
                    Count = rnd.Next(10, 1000),
                    Price = Convert.ToDecimal(rnd.Next(5, 100000) + rnd.NextDouble())
                };
                Products.Add(product); // TODO:
                result.Add(product);
            }
            return result;
        }

        // Random product generator.
        public List<Product> GetRandomProducts(int min, int max)
        {
            var result = new List<Product>();

            var count = rnd.Next(min, max);
            for(int i = 0; i < count; i++)
            {
                result.Add(Products[rnd.Next(Products.Count - 1)]);
            }
            return result;
        }

        // Random identifier.
        private static string GetRandomText()
        {
            return Guid.NewGuid().ToString().Substring(0, 5);
        }
    }
}
