using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpojExercises
{
    public class Reverse
    {
        public static void Run()
        {
            Console.WriteLine("Witaj. Ten program tworzy odbicie lustrzane słów które wpiszesz. Proszę, podaj ile słów będziesz chciał odbić: ");
            int x = int.Parse(Console.ReadLine());
            string[] a = new string[x];
            string[] b = new string[x];
            Console.WriteLine("Teraz podaj te słowa");
            for (int i = 0; i < x; i++)
            {
                a[i] = Console.ReadLine();
                b[i] = Reverse.ReverseWords(a[i]);
            }

            Console.WriteLine("Teraz zostaną wyświetlone słowa wraz z lustrzanym odbiciem: ");
            for (int i = 0; i < x; i++)
            {
                Console.WriteLine(a[i] + ' ' + b[i]);
            }
            
        }

        public static string ReverseWords(string word)
        {
            var temp = word.ToCharArray();
            Array.Reverse(temp);
            string rword = new string (temp);
            return rword;
            
        }
    }
}
