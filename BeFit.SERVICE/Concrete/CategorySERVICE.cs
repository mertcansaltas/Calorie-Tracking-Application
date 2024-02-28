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
    public class CategorySERVICE : ICategorySERVICE
    {
        /// <summary>
        /// Kategori işlemleriyle ilgili veritabanı işlemlerini gerçekleştiren bir _categoryrepo tanımlandı.
        /// _context adında özel bir BeFitAppContext türünden bir alan tanımlandı. Bu bir veritabanı bağlantısını temsil eder.
        /// </summary>
        private ICategoryREPO _categoryrepo;
        private readonly BeFitAppContext _context; 

        // Constructor metodu, BeFitAppContext bağlamını alır.
        public CategorySERVICE(BeFitAppContext context)
        {
            _context = context; // Bağlam alanına parametre olarak gelen BeFitAppContext nesnesini atar.
            _categoryrepo = new CategoryREPO(); // CategoryREPO sınıfından bir örnek oluşturur
        }
        //Categorynin databesine veri ekleme işlemi yapılır.
        public int Add(Category entity)
        {
            return _categoryrepo.Create(entity);
        }

        //Categorynin databesine veri silme işlemi yapılır.
        public int Delete(Category entity)
        {
            return _categoryrepo.Delete(entity);
        }
        //Categorynin databesine veri güncelleme işlemi yapılır.
        public int Update(Category entity)
        {
            return _categoryrepo.Update(entity);
        }

        //Categorynin tüm listesini getirir.
        public List<Category> GetAll()
        {
            return _context.Categories.ToList();
        }

        public List<Category> GetAllActive()
        {
            throw new NotImplementedException();
        }

        public Category GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Category> GetPages(int _skip, int _take, Func<Category, bool> expression = null)
        {
            throw new NotImplementedException();
        }

        public List<Category> GetWhere(Func<Category, bool> expression)
        {
            throw new NotImplementedException();
        }

       
    }
}
