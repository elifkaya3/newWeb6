using MiniShopApp.Bussiness.Abstract;
using MiniShopApp.Data.Abstract;
using MiniShopApp.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniShopApp.Bussiness.Concrete
{
    public class ProductManager : IProductService
    {
        IProductRepository _productRepository;
        public ProductManager(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }
        public void Create(Product entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Product entity)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll()
        {
            //burada ürünlerin listelenmesi sağlanıyor.
            //Fakat ürün listelenirken metot çalıştırılmadan önce çeşitli
            //iş kuralları uygulanacak(Validation vb.)
            return _productRepository.GetAll();
        }

        public Product GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetHomePageProduct()
        {
            return _productRepository.GetHomePageProduct();
        }

        public Product GetProductDetails(string url)
        {
            return _productRepository.GetProductsDetails(url);
        }


        public List<Product> GetProductsByCategory(string name)
        {
            return _productRepository.GetProductsByCategory(name);
        }

        public List<Product> GetSearchResult(string searchString)
        {
            return _productRepository.GetSearchResult(searchString);
        }

        public void Update(Product entity)
        {
            throw new NotImplementedException();
        }
    }
}
