using Shop.Core.Models;

namespace Shop.Business.Services.Iterfaces
{
    public interface IEmployee
    {
        public void Add(Employee employee);
        public void Remove(int Id);
        public void Edit(int Id);
    }
}
