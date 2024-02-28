using BeFit_DATA.Abstract;
using BeFit_DATA.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeFit_DATA.Concrete
{
    public class UserFood:BaseClass
    {
        public MealType MealType { get; set; }
        public double Quantity { get; set; }    
        public double TotalCalorie { get; set; }
        public DateTime Date { get; set; } = DateTime.Now;

        //Food ve UserFood arasında One To Many ilişki olduğundan dolayı ilişkiyi sağlayacak olan FoodID, foreign key olarak tanımlanmıştır.
        public int FoodID { get; set; }

        //User ve UserFood arasında One To Many ilişki olduğundan dolayı ilişkiyi sağlayacak olan UserID, foreign key olarak tanımlanmıştır.
        public int UserID { get; set; }

        public virtual Food Food { get; set; }
        public virtual User User { get; set; }

    }
}
