using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpojExercises
{
    public class ZadanieDoPracy
    {
        public static void Run()
        {
            //Program do liczenia ile jakich nominałów potrzebne jest do złożenia na podaną kwote.
            // A program for counting how many denominations are needed to deposit a given amount
            int i;
            int cash;
            Console.WriteLine("Podaj jakie nominały masz do dyspozycji, nominały oddziel przecinkiem (np. 100,10,5,1).");
            string banknotes = Console.ReadLine();
            string[]banknotesArrayString = banknotes.Split('\u002C');
            int[] banknotesArrayInt = new int[banknotesArrayString.Length];
            for (i = 0; i < banknotesArrayString.Length; i++)
            {
                bool temp = int.TryParse(banknotesArrayString[i], out int num);
                if (temp == true)
                {
                    banknotesArrayInt[i] = int.Parse(banknotesArrayString[i]);  
                }
                else if (temp == false)
                {
                    Console.WriteLine("Podłeś złe banknoty, pamiętaj, żeby podać je w formie cyfrowej. Po kliknięciu enter program zakonczy swoje działanie");
                    Console.ReadKey();
                    System.Environment.Exit(0);
                }
            }
            var banknotesLinq = banknotesArrayInt.OrderByDescending(x => x).ToList();
            Console.WriteLine("Podaj kwotę którą chcesz sprawdzić: ");
            string scash = Console.ReadLine();
            bool temp2 = int.TryParse(scash, out int num2); 
            if (temp2 == true)
            {
                cash = int.Parse(scash);
                for (int x = 0; x < banknotesLinq.Count(); x++)
                {
                    int tempcash = 0;
                    while (banknotesLinq[x] < cash)
                    {
                        cash = cash - banknotesLinq[x];
                        tempcash++;
                    }
                        Console.WriteLine("Potrzeba {0} nominałów {1}.", tempcash, banknotesLinq[x]);
                }
            }
        }
    }
}
