using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CounterProject
{
    public class Program
    {
        public static int value = 0;

        static void Main(string[] args)
        {
            //Counter c1 = new Counter();

            //c1.SetResult(10);
            //c1.Add(5);

            //Console.WriteLine(c1.GetResult());
            //Console.ReadKey();

            //Licz l1 = new Licz(0);
            //l1.Dodaj(5);
            //l1.Odejmij(2);
            //Console.WriteLine(l1.Wynik());
            //Console.ReadKey();

            //Statyczna.Zwieksz();
            //Console.WriteLine(Statyczna.Zwroc());
            //Console.ReadKey();

            //int[] b = new int[5];
            //b[0] = 1;
            //b[1] = 110;
            //b[2] = 5;
            //b[3] = 1;
            //b[4] = 6;

            //Sumator s1 = new Sumator(new int[] { 1, 2, 3, 4, 5 });
            //Sumator s2 = new Sumator(b);

            //s1.Index(2, 10000);

            Data d1 = new Data("G");
            d1.Odczyt();
            d1.PrzesunWPrzod();
            d1.Odczyt();

            Console.ReadKey();

        }
    }
}
