using System;

namespace ZabawneDodawaniePiotrusia
{
    class Program
    {
        static void Main()
        {
            int reverse;
            int input = int.Parse(Console.ReadLine());

            for ( ; ; )
            {
                string x = StringReverse(input);
                reverse = int.Parse(x);

                int result = reverse + input;
                string resultString = result.ToString();
                string resultStringReverse = StringReverse(result);

                if (resultString == resultStringReverse)
                {
                    Console.WriteLine(resultString);
                    return;
                }
                else
                {
                    input = result;
                }
            }

        }

        public static string StringReverse(int input)
        {
            string x = input.ToString();
            char[] z = x.ToCharArray();
            Array.Reverse(z);
            string reversed = new string(z);
            return reversed;
        }
    }
}
