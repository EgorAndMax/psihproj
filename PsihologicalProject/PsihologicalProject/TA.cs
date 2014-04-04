using System;

namespace PsihologicalProject
{
    class TA
    {
        public int IQ(int NumberOfCorrectAnswers)
        {
            return (int)(Math.Round(75 + NumberOfCorrectAnswers * 2.5 - 40, 0));
        }
        private static int[] _array = new int[40];
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
