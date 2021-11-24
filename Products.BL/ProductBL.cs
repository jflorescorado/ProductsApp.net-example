using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

// Imports
using Products.DAL;
using Products.Entities;

namespace Products.BL
{
    public class ProductBL
    {
        public async Task<int> Create(Product product)
        {
            return await ProductDAL.Create(product);
        }

        public async Task<int> Modify(Product product)
        {
            return await ProductDAL.Modify(product);
        }

        public async Task<int> Delete(Product product)
        {
            return await ProductDAL.Delete(product);
        }

        public async Task<Product> GetById(Product product)
        {
            return await ProductDAL.GetById(product);
        }

        public async Task<List<Product>> GetAll()
        {
            return await ProductDAL.GetAll();
        }
    }
}
