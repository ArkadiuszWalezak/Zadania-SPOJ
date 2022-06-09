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
            Console.WriteLine("Enter the radius of the circle: ");
            double r = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter enter the distance between the circles: ");
            double d = int.Parse(Console.ReadLine());

            double P = ((r*r - ((d*d)/4)) * 3.141592654);
            //Console.WriteLine("Th area is: {0}",P);
            //Console.WriteLine("\nPodany promień to: " + String.Format("{0:N2}", P));
            string values = Math.Round(P, 2).ToString();
            string valueRepleced = values.Replace( ",",  ".");
            Console.WriteLine("The area of the common circle is: {0}", valueRepleced);
            Console.ReadKey();
        }
    }
}
