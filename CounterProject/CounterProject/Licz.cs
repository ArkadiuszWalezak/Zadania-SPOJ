using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CounterProject
{
    internal class Licz
    {
        private int wartosc = 0;

        public Licz(int a)
        {
            wartosc = a;
        }

        public void Dodaj(int a)
        {
            wartosc += a;
        }
        public void Odejmij(int a)
        {
            wartosc -= a;
        }
        public int Wynik()
        {
            return wartosc;
        }
    }
}
