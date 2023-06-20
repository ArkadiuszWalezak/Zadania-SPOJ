using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SpojExercises
{
    public class Samolot
    {
        public static void Run()
        {
            Console.WriteLine("Witaj w programie, który oblicza miejsca siedzące w samolocie. Proszę, wprowadź: liczba rzędów klasy buisness, liczba miejsc siedzących w rzędzie, liczba rzędów klasy ekonomiczne, liczba siedzeń w rzędzie klasy ekonominczej. Liczby muszą być oddzielone spacją (format: 'a b c d')");
            var smiejsc = Console.ReadLine().Split(' ');
            if (Check(smiejsc))
            {
                int wynik = int.Parse(smiejsc[0]) * int.Parse(smiejsc[1]) + int.Parse(smiejsc[2]) * int.Parse(smiejsc[3]);
                Console.WriteLine("Ilość miejsc w samolocie to: {0}", wynik);
            } 
            else
            {
                Console.WriteLine("Podałeś liczbę poza zakresem lub za mało danych, wybierz cztery liczby z zakresu 1 a 1000");
                Console.WriteLine("Kliknij 'Enter', aby kontynuować");
                Console.ReadKey();
                Run();
            }
        }
        private static bool Check(string[] x)
        {
            bool result = true;

            for (int i = 0; i < 4; i++)
            {
                if (int.Parse(x[i])<1 || int.Parse(x[i]) > 1000 || x.Length <= 3)
                {
                    result = false;
                    return false;
                }
            }
            return result;
        }   
    }
}
