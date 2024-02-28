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
    public class FoodSERVICE : IFoodSERVICE
    {
        /// <summary>
        /// Food işlemleriyle ilgili veritabanı işlemlerini gerçekleştiren bir _foodrepo tanımlandı.
        /// _context adında özel bir BeFitAppContext türünden bir alan tanımlandı. Bu bir veritabanı bağlantısını temsil eder.
        /// </summary>
        private IFoodREPO _foodrepo;
        private readonly BeFitAppContext _context;

        // Constructor metodu, BeFitAppContext bağlamını alır.
        public FoodSERVICE(BeFitAppContext context)
        {
            _foodrepo = new FoodREPO(); //Food  sınıfından bir örnek oluşturur.
            _context = context; // Bağlam alanına parametre olarak gelen BeFitAppContext nesnesini atar.
        }
        //Food databesine veri ekleme işlemi yapılır.
        public int Add(Food entity)
        {
            return _foodrepo.Create(entity);
        }

        //Food databesine veri silme işlemi yapılır.
        public int Delete(Food entity)
        {
            return _foodrepo.Delete(entity);
        }
        //Food databesine veri güncelleme işlemi yapılır.
        public int Update(Food entity)
        {
            return _foodrepo.Update(entity);
        }
        //Food database de ki food listesini getirir.
        public List<Food> GetAll()
        {
            return _context.Foods.ToList();
        }

        //Verilen koşula göre Food listesini döndürür.
        public List<Food> GetWhere(Func<Food, bool> expression)
        {
            return _foodrepo.GetAll().Where(expression).ToList();
        }

        public List<Food> GetAllActive()
        {
            throw new NotImplementedException();
        }

        public Food GetById(int id)
        {
            throw new NotImplementedException();
        }

        

        
    }
}
