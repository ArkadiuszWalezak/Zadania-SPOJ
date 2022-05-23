using System;


namespace Zadania_liczby_pierwsze
{
    public class Program
    {
        static void Main(string[] args)
        {

            int i = 0;

            Console.Write("Teraz podaj byczqu, ile liczb chciałbyś sprawdzić, czy są pierwsze: ");

            int x = int.Parse(Console.ReadLine());

            while (i < x)
            {
                double liczba = Double.Parse(Console.ReadLine());

                if (Pierwsza(liczba))
                {
                    Console.WriteLine("No jest totalnie pierwsza");
                }
                else
                {
                    Console.WriteLine("Nie jest pierwsza");
                }
                i++;
            }
            Console.ReadKey();
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


