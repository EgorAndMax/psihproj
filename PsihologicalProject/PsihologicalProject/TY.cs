using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PsihologicalProject
{
    class TY
    {
        TY()
        {
            for (int i = 0; i < ArrayOfResults.Length; i++)
                ArrayOfResults[i] = -1;
        }
        public static int Result
        {
            get
            {
                int cnt = 0;
                foreach (int i in ArrayOfResults)
                    cnt += i;
                return cnt * 5;
            }
        }
        private static int Count = 20;
        private static int[] _array = new int[Count];
        public static int[] ArrayOfResults
        {
            get
            {
                return _array;
            }
            set { _array = value; }
        }

        public static string GetContent()
        {
            string buf = "";
            for (int m = 0; m < 20; m++)
            {
                buf += (m+1) + ") " + TY.ArrayOfResults[m] + "  ";
            }
            return buf;
        }
    }
}
