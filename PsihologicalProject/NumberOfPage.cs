using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PsihologicalProject
{
    class NumberOfPage
    {
        public static int Get(Type t)
        {
            string buf = t.ToString();
            int Number = 0;
            int i = buf.Length - 1;
            while (Char.IsDigit(buf[i]))
            {
                Number = Number * 10 + Int32.Parse(buf[i].ToString());
                i--;
            }
            return Number;
        }
    }
}
