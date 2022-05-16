﻿using MiniShopApp.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniShopApp.Bussiness.Abstract
{
    public interface IProductService
    {
        Product GetById(int id);
        List<Product> GetAll();
        void Create(Product entity);
        void Update(Product entity);
        void Delete(Product entity);

        List<Product> GetProductsByCategory(string name,int page,int pageSize);
        Product GetProductDetails(string url);
        List<Product> GetHomePageProduct();
        List<Product> GetSearchResult(string searchString);
        int GetCountByCategory(string category);

    }
}
