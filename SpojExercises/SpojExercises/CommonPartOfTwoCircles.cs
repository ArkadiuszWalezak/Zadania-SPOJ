using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpojExercises
{
    public class CommonPartOfTwoCircles
    {
        public static void Run()
        {
            double r;
            double d;

            Console.WriteLine("Enter the radius of the circle: ");
            Console.WriteLine("Enter enter the distance between the circles: ");

            double.TryParse(Console.ReadLine(), out r);
            double.TryParse(Console.ReadLine(), out d);

            double p = ((r*r - ((d*d)/4)) * 3.141592654);
            string values = Math.Round(p, 2).ToString().Replace(",", ".");

            Console.WriteLine("The area of the common circle is: {0}", values);
            Console.ReadKey();
        }
    }
}
