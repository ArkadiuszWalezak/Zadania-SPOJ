using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CounterProject
{
    public class Program
    {
        public static int value = 0;

        static void Main(string[] args)
        {
            Counter c1 = new Counter();

            c1.SetResult(10);
            c1.Add(5);

            Console.WriteLine(c1.GetResult());
            Console.ReadKey();
        }
    }
}
