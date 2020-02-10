using Restaurant.WebApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurant.WebApplication.Repository
{
    public interface IProductRepository
    {
        Products Create(Products product);
        void Delete(Products product);
        Products GetProduct(int productId);
    }
}
