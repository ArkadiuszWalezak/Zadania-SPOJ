using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpojExercises
{
    public static class Stefan
    {
        public static void Run()
        {
            Console.WriteLine("Please, enter the number of entries.");
            int entriesNumber = 0;
            bool validation = int.TryParse(Console.ReadLine(), out int result);

            if (validation)
            {
                entriesNumber = result;
            }
            else
            {
                Console.WriteLine("Please, insert valid number. Press enter to continue.");
                Console.ReadKey();
                Console.Clear();
                Run();
            }


            int[] income = new int[entriesNumber];

            Console.WriteLine("Please, enter {0} numbers", entriesNumber);

            for (int i = 0; i < entriesNumber; i++)
            {
                bool validation2 = int.TryParse(Console.ReadLine(), out int result2);
                if (validation2)
                {
                    income[i] = result2;
                }
                else
                {
                    Console.WriteLine("You didn't enter correct number. Number set to -1");
                    income[i] = -1;
                }
            }

            int tempMain = 0;
            int temp = 0;

            for (int i = 0; i < entriesNumber; i++)
            {
                if (income[i] >= 0)
                {
                    temp = temp + income[i];
                }
                if (income[i] < 0)
                {
                    if (tempMain < temp)
                    {
                        tempMain = temp;
                        temp = 0;
                    }
                }
                if (i == entriesNumber - 1)
                {
                    if (tempMain < income[i])
                    {
                        tempMain = temp;
                        temp = 0;
                    }
                }
            }

            Console.WriteLine(tempMain);
            Console.ReadKey();
        }
    }
}
