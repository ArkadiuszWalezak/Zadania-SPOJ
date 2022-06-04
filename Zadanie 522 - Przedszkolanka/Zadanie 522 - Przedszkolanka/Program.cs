using System;

namespace Zadanie_522___Przedszkolanka
{
    public class Program
    {
        static void Main(string[] args)
        {
            int l = 0;
            int p = 0;

            Console.WriteLine("Program liczy najniższą wspólną wielokrotnośc. Podaj ile par liczb chcesz sprawdzić:");
            int x = int.Parse(Console.ReadLine());
            int[] n = new int[x];
            int[] m = new int[x];

            Console.WriteLine("Teraz podaj pary:");

            while (l < x)
            {
                n[l] = int.Parse(Console.ReadLine());
                m[l] = int.Parse(Console.ReadLine());
                l++;
            }

            while (p < x)
            {
                Console.WriteLine("Wynik: ");
                Console.WriteLine(NWW(n[p],m[p]));
                p++;
            }
            Console.ReadKey();
        }

        public static int NWW(int a, int b)
        {
            int num1, num2;                 
            
            if (a > b)
            {
                num1 = a; 
                num2 = b;
            } 
            else
            {
                num1 = b; 
                num2 = a;
            }

            for (int i = 1; i <= num2; i++)
            {
                if ((num1 * i) % num2 == 0)
                {
                    return i * num1;
                }
            }
            return num2;
        }
    }
}