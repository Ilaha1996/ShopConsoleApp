using Shop.Core.Models;

namespace Shop.Business.Services.Iterfaces
{
    public interface IProduct
    {
        public void Add(Product product);
        public void Remove(int Id);
        public void Edit(int Id);
    }
}
