using BeFit_DATA.Abstract;
using BeFit_DATA.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeFit_DATA.Concrete
{
    public class User : BaseClass
    {
        public User()
        {
            UserFoods = new HashSet<UserFood>();
        }

        private string _lastName;

        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value.ToUpper().Substring(0, 1) + value.ToLower().Substring(1); }
        }

        public string UserMail { get; set; }
        private string _password;


        // Şifrenin en az 7 karakter olması, en az bir büyük harf, " + "bir küçük harf, bir sayısal karakter içermesi ve hem sayısal hem de metinsel karakterlerden oluşması gerektiği için kapsülleme işlemi yaptık.
        public string Password
        {
            get { return _password; }
            set
            {
                if (value.Length < 7 || !value.Any(char.IsUpper) || !value.Any(char.IsLower) || !value.Any(char.IsDigit) )
                {
                    string ex = "The password is invalid. It must be at least 7 characters long, contain at least one uppercase letter, one lowercase letter, one numeric character, and consist of both numeric and text characters.";
                    throw new Exception(ex);
                }
                  
                else
                    _password = value;
            
            }
        }


        public string Phone { get; set; }
        public double Weight { get; set; }
        public double Height { get; set; }
        public int Age { get; set; }

        //Gender'i enum olarak tanımladık.
        public Gender Gender { get; set; }

        //Status'u enum olarak tanımladık.
        public Status Status { get; set; }

        //TrainingLevel'i enum olarak tanımladık.
        public TrainingLevel TrainingLevel { get; set; }

        //Oluşma tarihini default olarak atadık ve default'a DateTime.Now dedik.
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public DateTime DeletedDate { get; set; }
        public double BodyMassIndex { get; set; }
        //User ve UserFood arasında One To Many ilişkisi var. UserFood many oldugu için ICollection tipinde tanımladık.
        public virtual ICollection<UserFood> UserFoods { get; set; }

    }
}
