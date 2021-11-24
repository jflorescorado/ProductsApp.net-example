using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Imports
using Microsoft.EntityFrameworkCore;
using Products.Entities;

namespace Products.DAL
{
    public class ProductDAL
    {
        public static async Task<int> Create(Product product)
        {
            int result = 0;

            using (var dbContext = new DBContext())
            {
                dbContext.Add(product);
                result = await dbContext.SaveChangesAsync();
            }

            return result;
        }

        public static async Task<int> Modify(Product updateProduct)
        {
            int result = 0;

            using (var dbContext = new DBContext())
            {
                var product = await dbContext.Product.FirstOrDefaultAsync(s => s.Id == updateProduct.Id);

                product.Code = updateProduct.Code;
                product.ProductName = updateProduct.ProductName;
                product.Description = updateProduct.Description;
                product.BarCode = updateProduct.BarCode;
                product.Existence = updateProduct.Existence;
                product.PriceCost = updateProduct.PriceCost;
                product.PriceCost = updateProduct.PriceCost;
                product.ProductStatus = updateProduct.ProductStatus;

                dbContext.Update(product);

                result = await dbContext.SaveChangesAsync();
            }

            return result;

        }

        public static async Task<int> Delete(Product deleteProduct)
        {
            var result = 0;

            using (var dbContext = new DBContext())
            {
                var product = await dbContext.Product.FirstOrDefaultAsync(s => s.Id == deleteProduct.Id);
                dbContext.Product.Remove(product);
                result = await dbContext.SaveChangesAsync();
            }

            return result;
        }

        public static async Task<Product> GetById(Product product)
        {
            Product result = new Product();

            using (var dbContext = new DBContext())
            {
                result = await dbContext.Product.FirstOrDefaultAsync(s => s.Id == product.Id);
            }

            return result;
        }

        public static async Task<List<Product>> GetAll()
        {
            var products = new List<Product>();

            using (var dbContext = new DBContext())
            {
                products = await dbContext.Product.ToListAsync();
            }

            return products;
        }
    }
}
