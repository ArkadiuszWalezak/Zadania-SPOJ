using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CounterProject
{
    internal class Statyczna
    {
        int I;
        static int liczba;

        public static void Zwieksz()
        {
            liczba += 1;
        }

        public static int Zwroc()
        {
            return liczba;
        }
    }
}
