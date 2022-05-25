using System;


namespace Zadanie_SPOJ_496___dwie_cyfry_silni
{
    
    //Program który liczy silnie. Pierwsze podaj ilość liczb do obliczenia, potem konkretne liczby do obliczeń.
    
    public class Program
    {
        static void Main(string[] args)
        {
            double y = 0;
            int z = 0;
            int l = 0;

            double x = double.Parse(Console.ReadLine());
            double[] n = new double [30];

            while (y < x)
            {
                n[z] = double.Parse(Console.ReadLine());
                z++;
                y++;

            }
            
            while (l < x)
            {
                Console.WriteLine(Mierzewa.Silnia(n[l]));
                l++;
            }
            Console.ReadKey();
        }
        
    }

    public class Mierzewa
    {
        public static double Silnia(double liczba)
        {
            double n = 1;

            for (double i = 1; i <= liczba; i++)
            {
                n = n * i;
            }
            liczba = n;
            return liczba;
        }
    }
}
