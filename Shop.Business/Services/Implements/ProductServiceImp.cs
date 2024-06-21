using Shop.Business.Services.Iterfaces;
using Shop.Core.Models;
using Shop.Data.DAL;
using System.Security.Cryptography.X509Certificates;

namespace Shop.Business.Services.Implements
{
    public class ProductServiceImp : IProduct
    {
        public void Add(Product product)
        {
            ShopDataBase.products.Add(product);            
        }

        public void Edit(int Id)
        {
            
        }

        public void Remove(int Id)
        {
            ShopDataBase.products.Remove(ShopDataBase.products.Find(x => x.Id == Id));            
        }
    }
}
