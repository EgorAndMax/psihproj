using System;
using System.Collections.Generic;

namespace PsihologicalProject
{
    class Psihologist
    {
        private static Type[] List = { typeof(Aizenk), typeof(Frade), typeof(Yung) };
        private static Type Last;
        public static Type Get()
        {
            Random r = new Random();
            Type temp;
            while ((temp = List[r.Next(0, List.Length)]) == Last) { }
            Last = temp;
            return temp;
        }
    }
}
