using BeFit_DATA.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeFit.SERVICE.Interfaces
{
    public interface IUserFoodSERVICE
    {
        int Add(UserFood entity);
        int Update(UserFood entity);
        int Delete(UserFood entity);
        UserFood GetById(int id);
        List<UserFood> GetAll();
        List<UserFood> GetAllActive();
        List<UserFood> GetWhere(Func<UserFood, bool> expression);
        List<UserFood> GetPages(int _skip, int _take, Func<UserFood, bool> expression = null);
        public void AddUserFood(UserFood userFood);
    }
}
