using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpojExercises
{
    public class PalindromeExerciseClass
    {
        public static void Run()
        {
            int reverse;
            int input = int.Parse(Console.ReadLine());

            for (; ; )
            {
                string x = StringReverse(input);
                reverse = int.Parse(x);

                int result = reverse + input;
                string resultString = result.ToString();
                string resultStringReverse = StringReverse(result);

                if (resultString == resultStringReverse)
                {
                    Console.WriteLine(resultString);
                    Console.WriteLine("Wcisnij enter zeby zakonczyc i rozpoczac nowy program (if exists XD)");
                    Console.ReadLine();
                    break;
                }
                else
                {
                    input = result;
                }
            }

        }

        private static string StringReverse(int input)
        {
            string x = input.ToString();
            char[] z = x.ToCharArray();
            Array.Reverse(z);
            string reversed = new string(z);
            return reversed;
        }
    
    }
}
