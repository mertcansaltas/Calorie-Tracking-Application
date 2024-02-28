using BeFit_DATA.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BeFit_REPO.Interfaces
{
    public interface IBaseREPO<T> where T : BaseClass
    {
        int Create(T entity);
        int Update(T entity);
        int Delete(T entity);

        // T ye göre bütün Listeyi getirir.
        List<T> GetAll();

        // Verilen id ye göre T'yi döndürür.
        T GetById(int id);

        //T tipinde koşula göre tüm listeyi getirir.
        List<T> GetAllWhere(Expression<Func<T, bool>> expression);
         T GetUserByEmailAndPassword(string email, string password);
    }
}
