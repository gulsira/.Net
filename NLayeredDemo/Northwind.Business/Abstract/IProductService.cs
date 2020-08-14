using Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Business.Abstract
{
    public interface IProductService
    {
        List<Product> GetAll();
        List<Product> GetProductsByCategory(int categoryId);
        List <Product> SearchProductsByName(string categoryName);
        void Add(Product product);
        void Edit(Product product);
        void Delete(Product product);
    }
}
