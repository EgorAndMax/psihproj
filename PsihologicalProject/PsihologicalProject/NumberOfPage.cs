using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PsihologicalProject
{
    class NumberOfPage
    {
        public static int Get(object t)
        {
            string buf = t.ToString();
            int Number = 0;
            int i = buf.Length - 1;
            while (Char.IsDigit(buf[i]))
            {
                Number = Int32.Parse(buf[i].ToString() + ((Number != 0)?(Number.ToString()):("")));
                i--;
            }
            var messageDialog = new Windows.UI.Popups.MessageDialog("Number = " + Number);
            return Number;
        }
    }
}
