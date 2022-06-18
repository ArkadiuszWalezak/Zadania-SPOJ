using System;

namespace CounterProject
{
    internal class Sumator
    {
        private int[] Liczby;

        public Sumator(int[] a)
        {
            Liczby = a;
        }

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

            Console.ReadKey();
        }

        public void Index(int lowIndex, int highIndex)
        {
            if (lowIndex < 0)
            {
                Console.WriteLine("Podałeś za mały low index, ustawiłem go na najniższą wartość");
                lowIndex = 0;
            }

            if (highIndex > Liczby.Length)
            {
                Console.WriteLine("Podałeś za duży high index, ustawiłem go na najwyższą wartoś");
                highIndex = Liczby.Length;
            }

            if (lowIndex > highIndex)
            {
                int temp = lowIndex;
                lowIndex = highIndex;
                highIndex = temp;
            }

            for (int i = lowIndex; i < highIndex; i++)
            {
                Console.WriteLine(Liczby[i]);
            }
            Console.ReadKey();

        }
    }
}
