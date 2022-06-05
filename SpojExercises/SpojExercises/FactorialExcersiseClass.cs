using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpojExercises
{
    public class FactorialExcersiseClass
    {
        public static void Run()
        {
            double y = 0;
            int z = 0;
            int l = 0;

            double x = double.Parse(Console.ReadLine());
            double[] n = new double[30];

            while (y < x)
            {
                n[z] = double.Parse(Console.ReadLine());
                y++;
            }

            while (l < x)
            {
                Console.WriteLine(Silnia(n[l]));
                string dwa = Silnia(n[l]).ToString();
                Console.WriteLine(dwa[dwa.Length - 1]);
                l++;
            }
            Console.WriteLine("Wcisnij enter zeby zakonczyc i rozpoczac nowy program (if exists XD)");
            Console.ReadKey();
        }
        public static double Silnia(double liczba)
        {
            double n = 1;

            for (int i = 1; i <= liczba; i++)
            {
                //n = n * i;
                n *= i;
            }

            return n;
        }
    }
}
