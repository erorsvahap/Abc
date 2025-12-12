using Entities.Concrete;
using Microsoft.EntityFrameworkCore.Query.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IProductService
    {
        List<Product> GetAll();
        List<Product> GetAllByCategory(int categoryId);
        void Add(Product product);
        void Update(Product product);
        void Delete(int  productId);
        Product GetById(int productId);

    }
}
