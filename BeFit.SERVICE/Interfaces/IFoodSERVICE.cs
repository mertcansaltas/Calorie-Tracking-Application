using BeFit_DATA.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeFit.SERVICE.Interfaces
{
   public interface IFoodSERVICE
    {
        int Add(Food entity);
        int Update(Food entity);
        int Delete(Food entity);
        Food GetById(int id);
        List<Food> GetAll();
        List<Food> GetAllActive();
        List<Food> GetWhere(Func<Food, bool> expression);
    }
}
