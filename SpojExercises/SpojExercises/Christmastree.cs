using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpojExercises
{
    public class Christmastree
    {
        public static void Run()
        //{
        //    int k,l;

        //    l = int.Parse(Console.ReadLine());
        //    k = int.Parse(Console.ReadLine());
            
            

        //    for (int i = 0; i < k; i++)
        //    {
        //        Console.WriteLine();
               
        //        for (int j = 0; j < l; j++)
        //        {
                  
        //            Console.Write("*");
        //        }
                
        //    }

        //    Console.ReadKey();
        //}

                
        
        {
            int spaces = 10;
            int asterix = 1;
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < spaces; j++)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j < asterix; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
                asterix++;
                spaces--;
            }
            Console.ReadKey();
        }
    }
}

