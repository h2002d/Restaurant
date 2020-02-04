using Restaurant.WebApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurant.WebApplication.Repository.Product
{
    interface IProductImageRepository
    {
        ProductImages Create(ProductImages product);
        void Delete(ProductImages product);
        ProductImages GetProductImage(int productId);
    }
}
