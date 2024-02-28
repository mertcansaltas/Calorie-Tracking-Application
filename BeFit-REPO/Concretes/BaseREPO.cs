using BeFit_DATA.Abstract;
using BeFit_DATA.Concrete;
using BeFit_REPO.Context;
using BeFit_REPO.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BeFit_REPO.Concretes
{
    public class BaseREPO<T> : IBaseREPO<T> where T : BaseClass
    {
        //Sürekli using dememek için burada db tanımladım.Readonly,Bir değişkenin sadece bir kez başlatılabileceğini ve daha sonra değiştirilemeyeceğini belirtir.İlk oluştuğu anda newlenir.Readonly yazdığım için yeniden newleme işlemi yaptığımızda program hata verir.Sadece bu classın içinde kullanmak için private yazdım.
        private readonly BeFitAppContext db;
        public BaseREPO()
        {
            db = new BeFitAppContext();   
        }
        public int Create(T entity)
        {
            if (entity is not null)    
                db.Add(entity);
            return db.SaveChanges();

            throw new Exception("Nesne boş olamaz.");
        }

        public int Delete(T entity)
        {
            if (entity is not null)
                db.Remove(entity);
            return db.SaveChanges();

            throw new Exception("Nesne boş olamaz.");
        }
        public int Update(T entity)
        {
            
            db.Entry(entity).State = EntityState.Modified; // Entity'nin durumunu değiştirerek güncellenmiş durumunu belirtiyoruz.State,nesnelerin veritabanındaki durumunu takip eder. Bu durumlar, bir nesnenin eklenip, güncellenip veya silinip silinmediğini belirtir.EntityState.Modified (Değiştirilmiş Durum): bir nesnenin veritabanında değişiklik yapıldığını ve güncellenmesi gerektiğini belirtir. Yani, nesnenin güncellenmiş bir versiyonunu veritabanına kaydetmek istediğimizi ifade eder.
            return db.SaveChanges();
        }

        public List<T> GetAll()
        {
            //Set,contextin üzerinde dbsetlere gidip verdiğim T ye bakıp o listeyi getirir.Db sete erişir.
            var list = db.Set<T>().ToList(); 
            if (list is not null) 
                return list;
            else
                throw new Exception("Böyle bir data yok");
        }

        public List<T> GetAllWhere(Expression<Func<T, bool>> expression)
        {
            //Where IQuerayble döndüğü için ToList dedim.Liste IEnumarayble döner.
            return db.Set<T>().Where(expression).ToList();
        }

        public T GetById(int id)
        {
            //Set kullanarak verdiğim tipe göre db sete gidip id sini döndürür.Geriye T döner.
            return db.Set<T>().Find(id); 
        }

        public T GetUserByEmailAndPassword(string email, string password)
        {
            throw new NotImplementedException();
        }
    }
}
