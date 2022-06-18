using System;

namespace CounterProject
{
    internal class Sumator
    {
        private int[] Liczby;

        Sumator s1 = new Sumator();

        public int Suma()
        {
            int a = Liczby.Length;
            int c = 0;

            for (int i = 0; i < a; i++)
            {
                int b = Liczby[i];
                c += b;
            }
            return c;
        }

        public int IleElementów()
        {
            return Liczby.Length;
        }

        public void Wypisz()
        {
            int a = 0;

            while (a < Liczby.Length)
            {
                Console.WriteLine(Liczby[a]);
                a++;
                 
            }
        }
        //public int Index(int lowIndex, int highIndex)
        //{
        //    //kurde nie za bardzo kumam, zadanie 2e
        //}


    }
}
