using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main()
    {
        string input = Console.ReadLine();
        string[] subs = input.Split(' ');

        //--- Rozwiazanie z odczytywaniem tablicy od tylu ---
        for (int licznik = 0; licznik < subs.Length; licznik++)
        {
            Console.Write(subs[subs.Length - licznik - 1]);
        }

        //--- Rozwiazanie ze stworzeniem listy i z jej odwroceniem ---

        //List<string> subs1 = subs.ToList();
        //subs1.Reverse();
        //
        //for (int licznik = 0; licznik < subs1.Count; licznik++)
        //{
        //    Console.Write(subs1[licznik]);
        //}
    }
}