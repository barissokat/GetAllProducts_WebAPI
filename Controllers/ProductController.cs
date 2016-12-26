using GetAllProducts_WebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace GetAllProducts_WebAPI.Controllers
{
    public class ProductController : ApiController
    {
        private List<Product> _products = new List<Product>
        {
            new Product { Id = 1, Name = "Desktop Computer", Price = 4200, CategoryName = "Computer", Stock = 150 },
            new Product { Id = 2, Name = "Laptop Computer", Price = 3500, CategoryName = "Computer", Stock = 300 },
            new Product { Id = 3, Name = "LCD Television", Price = 1900, CategoryName = "Television", Stock = 450 },
            new Product { Id = 4, Name = "LED Television", Price = 1400, CategoryName = "Television", Stock = 200 }
        };
        public IEnumerable<Product> GetAllProducts()
        {
            return _products;
        }
    }
}
