using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeFitUi
{
    public class Methods
    {
        public static void Clear(Control.ControlCollection collection)
        {
            foreach (Control item in collection)
            {
                if (item is TextBox)
                    ((TextBox)item).Clear();
                else if (item is ComboBox)
                    ((ComboBox)item).SelectedIndex = -1;
                else if (item is PictureBox)
                    ((PictureBox)item).Image = null;
                else if (item is GroupBox)
                    Clear(((GroupBox)item).Controls);
            }
        }
    }
}
