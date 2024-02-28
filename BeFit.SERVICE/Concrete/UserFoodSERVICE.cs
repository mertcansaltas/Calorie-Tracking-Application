using BeFit.SERVICE.Interfaces;
using BeFit_DATA.Concrete;
using BeFit_REPO.Concretes;
using BeFit_REPO.Context;
using BeFit_REPO.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeFit.SERVICE.Concrete
{
    public class UserFoodSERVICE : IUserFoodSERVICE
    {
        /// <summary>
        /// UserFood işlemleriyle ilgili veritabanı işlemlerini gerçekleştiren bir _userfoodrepo tanımlandı.
        /// _context adında özel bir BeFitAppContext türünden bir alan tanımlandı. Bu bir veritabanı bağlantısını temsil eder.
        /// </summary>
        private IUserFoodREPO _userfoodrepo;
        private readonly BeFitAppContext _context;
        // Constructor metodu, BeFitAppContext bağlamını alır.
        public UserFoodSERVICE(BeFitAppContext context)
        {
            _context = context; // Bağlam alanına parametre olarak gelen BeFitAppContext nesnesini atar.
            _userfoodrepo = new UserFoodREPO(); //UserFood sınıfından bir örnek oluşturur.
        }
        public void AddUserFood(UserFood userFood)
        {
            _context.UserFoods.Add(userFood);
            _context.SaveChanges();
        }
        //Kullanıcının ve kullanıcının seçtiği besinin verilerini içeren bir nesneyi veritabanına ekler.
        public int Add(UserFood entity)
        {
            return _userfoodrepo.Create(entity);
        }
        //Kullanıcının ve kullanıcının seçtiği besinin verilerini içeren bir nesneyi veritabanına siler.
        public int Delete(UserFood entity)
        {
            return _userfoodrepo.Delete(entity);
        }
        //Kullanıcının ve kullanıcının seçtiği besinin verilerini içeren bir nesneyi listeler.
        public List<UserFood> GetAll()
        {
            return _context.UserFoods.ToList();
        }

        public List<UserFood> GetAllActive()
        {
            throw new NotImplementedException();
        }

        public UserFood GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<UserFood> GetPages(int _skip, int _take, Func<UserFood, bool> expression = null)
        {
            throw new NotImplementedException();
        }

        public List<UserFood> GetWhere(Func<UserFood, bool> expression)
        {
            throw new NotImplementedException();
        }

        //Kullanıcının ve kullanıcının seçtiği besinin verilerini içeren bir nesneyi günceller.
        public int Update(UserFood entity)
        {
            return _userfoodrepo.Update(entity);   
        }
    }
}
