using System;
using System.Collections.Generic;
using PsihologicalProject.Psihologists;

namespace PsihologicalProject
{
    class Psihologist
    {
        private static Type[] List = { typeof(Aizenk), typeof(Frade), typeof(Yung), typeof(Gardner), typeof(Karnegi), typeof(Behterev) };
        private static Type[] Last = new Type[3];
        public static Type Get()
        {
            Random r = new Random();
            Type temp;
            int randNum = r.Next(0, List.Length);
            while (((temp = List[randNum]) == Last[0]) || ((temp = List[randNum]) == Last[1]) || ((temp = List[randNum]) == Last[2])) 
            { 
                randNum = r.Next(0, List.Length); 
            }
            AddInListOfLast(temp);
            return temp;
        }
        private static void AddInListOfLast(Type t)
        {
            for (int i = Last.Length - 1; i > 0; i--)
                Last[i] = Last[i - 1];
            Last[0] = t;
        }
    }
}
