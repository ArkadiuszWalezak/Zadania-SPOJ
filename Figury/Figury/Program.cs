using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figury
{

    //Projekt Figury - dziedziczenie i klasy abstrakcyjne
    // - stworz klase abstrakcyjna "Figura" i publiczna metode abstrakcyjna "Oblicz Pole", prywatne pole typu double o nazwie "Pole", getter i setter publiczny do tego Pola, publiczna metode WypiszPole
    // - stworz klasy "Kolo", "Kwadrat", "Trojkat" dziecdziczącce klase Figura i implementujace potrzebne metody
    // - dostosuj klasy tak aby dzialaly poprawnie
    class Program
    {
        static void Main()
        {
            Figura k1 = new Kwadrat("kwadrat",5);
            k1.ObliczPole();
            k1.WypiszPole();

            Figura d1 = new Kolo("kolo", 5);
            d1.ObliczPole();
            d1.WypiszPole();

            Figura t1 = new Trojkat("trojkat", 5, 5);
            t1.ObliczPole();
            t1.WypiszPole();

            Console.ReadKey();
        }
    }
}
