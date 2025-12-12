using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class ProductManager : IProductService
    {
        private IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public void Add(Product product)
        {
             _productDal.Add(product);
        }

        public void Delete(int productId)
        {
            var product = _productDal.Get(p => p.ProductID == productId);
            _productDal.Delete(product);
        }

        public List<Product> GetAll()
        {

            return _productDal.GetList();
        }

        public List<Product> GetAllByCategory(int categoryId)
        {
            return _productDal.GetList(p => p.CategoryID == categoryId || categoryId==0);
        }

        public Product GetById(int productId)
        {
                
          return  _productDal.Get(p => p.ProductID == productId);
        }

        public void Update(Product product)
        {
           _productDal.Update(product);
        }
    }
}
