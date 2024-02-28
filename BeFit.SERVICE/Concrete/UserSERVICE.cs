using BeFit.SERVICE.Interfaces;
using BeFit_DATA.Concrete;
using BeFit_REPO.Concretes;
using BeFit_REPO.Context;
using BeFit_REPO.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace BeFit.SERVICE.Concrete
{
    public class UserSERVICE : IUserSERVICE
    {
        /// <summary>
        /// User işlemleriyle ilgili veritabanı işlemlerini gerçekleştiren bir  _userrepo tanımlandı.
        /// _context adında özel bir BeFitAppContext türünden bir alan tanımlandı. Bu bir veritabanı bağlantısını temsil eder.
        /// </summary>
        private IUserREPO _userrepo;
        private readonly BeFitAppContext _context;

        public UserSERVICE(BeFitAppContext context)
        {
            _userrepo = new UserREPO(); //User sınıfından bir örnek oluşturur.
            _context = context; // Bağlam alanına parametre olarak gelen BeFitAppContext nesnesini atar.
        }

        //User tipinde entity nesnesini Userın databaseine ekler,kaydeder ve o verinin id sini döndürür.
        public int Add(User entity)
        {
            _context.Users.Add(entity);
            _context.SaveChanges();
            return entity.ID;
        }

        //User tipinde entity nesnesini siler.
        public int Delete(User entity)
        {
            return _userrepo.Delete(entity);           
        }

        //User databaseine listeler.
        public List<User> GetAll()
        {
            return _context.Users.ToList();
        }

        public List<User> GetAllActive()
        {
            throw new NotImplementedException();
        }

        //Parametrede verilen idye göre Kullanıcıyı getirir.
        public User GetById(int id)
        {
            return _context.Users.FirstOrDefault(u => u.ID == id);
        }

        public List<User> GetPages(int _skip, int _take, Func<User, bool> expression = null)
        {
            throw new NotImplementedException();
        }

        public List<User> GetWhere(Func<User, bool> expression)
        {
            throw new NotImplementedException();
        }

        //User tipinde entity nesnesini güncelleme işlemini yapar.
        public int Update(User entity)
        {
            return _userrepo.Update(entity);
        }

        /// <summary>
        /// Bu method girilen maile ve şifreye göre kullanıcıyı veritabanından alır.
        /// </summary>
        /// <param name="email"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public User GetUserByEmailAndPassword(string email, string password)
        {
            return _context.Users.FirstOrDefault(x => x.UserMail == email && x.Password == password);
        }
       
    }
}
