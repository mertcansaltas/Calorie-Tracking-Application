using BeFit_DATA.Abstract;
using BeFit_DATA.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeFit_DATA.Concrete
{
    public class Food:BaseClass
    {
        public Food()
        {
            UserFoods = new HashSet<UserFood>();
        }
        //PortionType'ı enum olarak tanımladık.
        public PortionType PortionType { get; set; } 
        public double Calorie { get; set; }
        public double Fat { get; set; }
        public double Protein { get; set; }
        public double Carbohydrate { get; set; }
        
        //Category ve Food arasında One To Many ilişki olduğundan dolayı ilişkiyi sağlayacak olan CategoryID, foreign key olarak tanımlanmıştır.
        public int CategoryID { get; set; }
        public virtual Category Category { get; set; }

        //Food ve UserFood arasında One To Many ilişkisi var. UserFood many oldugu için ICollection tipinde tanımladık.
        public virtual ICollection<UserFood> UserFoods { get; set; }

        //Null olarak geçilebilir.
        public string? Picture { get; set; } 
    }
}
