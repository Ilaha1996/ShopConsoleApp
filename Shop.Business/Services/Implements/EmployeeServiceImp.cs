using Shop.Business.Services.Iterfaces;
using Shop.Core.Models;
using Shop.Data.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Business.Services.Implements
{
    public class EmployeeServiceImp : IEmployee
    {
        
        public void Add(Employee employee)
        {
            ShopDataBase.employees.Add(employee);
        }

       
        public void Edit(int Id)
        {
            
        }
        
        public void Remove(int Id)
        {
            ShopDataBase.employees.Remove(ShopDataBase.employees.Find(x => x.Id == Id));
        }
    }
}
