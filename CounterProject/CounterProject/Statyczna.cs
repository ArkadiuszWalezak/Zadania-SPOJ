using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CounterProject
{
    public class Statyczna
    {
        int I;
        static int liczba;

        public Statyczna()
        {
            Zwieksz();
            I = 0;
        }

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
