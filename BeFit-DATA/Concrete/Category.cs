using BeFit_DATA.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeFit_DATA.Concrete
{
    public class Category:BaseClass
    {
        public Category()
        {
            Foods=new HashSet<Food>();  
        }
        public ICollection<Food> Foods { get; set; } // Bir kategori içerisinde birden fazla yiyecek var ancak bir yiyeceğin birden fazla kategorisi olmadıgından dolayı burada One To Many ilişkisi var. Yiyecek many oldugu için ICollection tipinde tanımladık.
    }
}
