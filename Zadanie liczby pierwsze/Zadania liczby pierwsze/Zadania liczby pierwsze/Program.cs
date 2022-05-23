using System;


namespace Zadania_liczby_pierwsze
{
    public class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                double liczba = Double.Parse(Console.ReadLine());

                if (Pierwsza(liczba))
                {
                    Console.WriteLine("Powinna być pierwsza");
                }
                else
                {
                    Console.WriteLine("Nie jest pierwsza");
                }
            }
        }
        
        
        public static bool Pierwsza(double liczba)
        {
            if (liczba == 1)
            {
                return false;
            }
            if (liczba == 2)
            {
                return true;
            }
            if (liczba % 2 == 0)
            {
                return false;
            }
            else
            {
                for (int i = 3; i < liczba; i += 2)
                {
                    if ((liczba % i) == 0)
                    {
                        return false;
                    }
                }

            return true;
            }


    }
    }
}


