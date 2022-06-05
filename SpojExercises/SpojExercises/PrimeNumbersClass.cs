using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpojExercises
{
    public class PrimeNumbersClass
    {
        public static void Run()
        {
            int i = 0;

            Console.Write("Teraz podaj byczqu, ile liczb chciałbyś sprawdzić, czy są pierwsze: ");

            int x = int.Parse(Console.ReadLine());

            while (i < x)
            {
                double liczba = Double.Parse(Console.ReadLine());

                if (Prime(liczba))
                {
                    Console.WriteLine("No jest totalnie pierwsza");
                }
                else
                {
                    Console.WriteLine("Nie jest pierwsza");
                }
                i++;
            }

            Console.WriteLine("Wcisnij enter zeby zakonczyc i rozpoczac nowy program (if exists XD)");
            Console.ReadKey();
        }

        public static bool Prime(double number)
        {
            if (number == 1)
            {
                return false;
            }
            if (number == 2)
            {
                return true;
            }
            if (number % 2 == 0)
            {
                return false;
            }
            else
            {
                for (int i = 3; i < number; i += 2)
                {
                    if ((number % i) == 0)
                    {
                        return false;
                    }
                }
                return true;
            }
        }
    }
}
