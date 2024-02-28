using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeFit_DATA.Abstract


{/// <summary>
/// ID ve Name property'lerini tüm class'larda kullandığımız için kalıtım alacakları abstract class oluşturduk. Bu class'a da BaseClass ismini verdik. 
/// </summary>
    public abstract class BaseClass
    {        
        public int ID { get; set; }
        private string _name;

        public string Name
        {
            get { return _name; }
            set 
            { _name = value.ToUpper().Substring(0, 1) + value.ToLower().Substring(1); }
        }
    }
}
