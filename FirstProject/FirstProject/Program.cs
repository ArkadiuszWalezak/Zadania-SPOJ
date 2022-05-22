using System;

//Program, który:
// - wczytuje ze standardowego wejścia: podstawę 'a' oraz wykładnik 'b',
// - wypisuje ostatnią cyfrę liczby ab (wyniku potegowania),

public class Program
{
    public static void Main()
    {
        while (true)
        {

            string input = Console.ReadLine(); //a b
            string[] subs = input.Split(' ');
            double da;
            double db;
            Double.TryParse(subs[0], out da);
            Double.TryParse(subs[1], out db);
            if (da != 0 && db != 0)
            {
                //string wynik = Math.Pow(da, db).ToString();
                string wynik = CustomMath.CustomPow(da, db).ToString();
                Console.WriteLine(wynik[wynik.Length - 1]);
                return;
            }
            else
            {
                Console.WriteLine("Podaj wartość inną od zera i żeby to były liczby ");
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}


public class CustomMath
{
    public static double CustomPow(double da, double db)
    {
        double wynik = 1;

        //--- Rozwiazanie z uzyciem petli while ---

        //int licznik = 0;
        //while (licznik < db)
        //{
        //    licznik = licznik + 1;
        //    wynik = wynik * da;
        //}

        //--- Rozwiazanie z uzyciem petli for ---

        for (int i = 0; i < db; i++)
        {
            wynik = wynik * da;
        }

        return wynik;
    }
}
