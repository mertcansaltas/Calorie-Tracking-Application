using BeFit_DATA.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeFit.SERVICE.Interfaces
{
    public interface ICategorySERVICE
    {
        int Add(Category entity);
        int Update(Category entity);
        int Delete(Category entity);
        Category GetById(int id);
        List<Category> GetAll();
        List<Category> GetAllActive();
        List<Category> GetWhere(Func<Category, bool> expression);
        List<Category> GetPages(int _skip, int _take, Func<Category, bool> expression = null);
    }
}
