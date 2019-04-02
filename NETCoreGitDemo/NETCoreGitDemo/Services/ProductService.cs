using System;
using System.Collections.Generic;
using NETCoreGitDemo.Models;

namespace NETCoreGitDemo.Services
{
    public class ProductService
    {
        public static ProductService Current { get; } = new ProductService();

        public List<Product> Products { get; }

        public ProductService()
        {
            Products = new List<Product>
            {
                new Product
                {
                Id=1,Name="面包"
                },
                new Product
                {
                Id=2,Name="牛奶"
                }
            };
        }
    }
}
