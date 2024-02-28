using BeFit_DATA.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeFit.SERVICE.Interfaces
{
    public interface IUserSERVICE
    {
        int Add(User entity);
        int Update(User entity);
        int Delete(User entity);
        User GetById(int id);
        List<User> GetAll();
        List<User> GetAllActive();
        List<User> GetWhere(Func<User, bool> expression);
        List<User> GetPages(int _skip, int _take, Func<User, bool> expression = null);

        /// <summary>
        /// Girilen mail ve şifre önceden kaydedilmiş bir kullanıcının mail ve şifresiyle eşleşiyorsa program diğer form sayfasını açar.Eşleşmiyorsa giriş bilgileri hatalı mesajı verir.
        /// </summary>
        /// <param name="email">Kullanıcının giriş yapmak için kullandığı mail</param>
        /// <param name="password">Kullanıcının giriş yapmak için kullandığı password</param>
        /// <returns></returns>
        User GetUserByEmailAndPassword(string email, string password);
    }
}
