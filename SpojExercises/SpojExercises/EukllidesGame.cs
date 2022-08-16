using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpojExercises
{
    public class EukllidesGame
    {
        public static void Run()
        {
            Console.WriteLine("Podaj liczbę partii: ");
            int x = int.Parse(Console.ReadLine());
            int[] a = new int[x];
            int[] b = new int[x];
            Console.WriteLine("Teraz podaj pary liczb");

            for (int i = 0; i < x; i++)
            {
                string k = Console.ReadLine();  
                string[] vs = k.Split(' ');
                int e = int.Parse(vs[0]);
                int g = int.Parse(vs[1]);
                a[i] = e;
                b[i] = g;
            }
           
            for (int i = 0; i < x; i++)
            {
                int k = a[i];
                int l = b[i];
                int num1 = 0;
                int num2 = 0;

                if (k > l)
                {
                    num1 = k;
                    num2 = l;
                }
                else
                {
                    num1 = l;
                    num2 = k;
                }
                
                if (num1 % num2 == 0)
                {
                    Console.WriteLine("Ilość żetonów końcowych to " + num2 * 2);
                }
                else 
                {
                    if (num1 > num2)
                    {
                       int m = num1 % num2;

                        while (m != 0)
                        {
                            num1 = num2;
                            num2 = m;
                            m = num1 % num2;
                        }
                    }
                    Console.WriteLine("Ilość żetonów końcowych to " + num2 * 2);
                }
            }

            for (int i = 0; i < x; i++)
            {
                Console.WriteLine(a[i] + " " + b[i]);
            }

            Console.ReadKey();

        }
    }
}
