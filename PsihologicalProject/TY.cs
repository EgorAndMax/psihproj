using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PsihologicalProject
{
    class TY
    {
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
    }
}
