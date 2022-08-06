using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaborkiPO02
{
    public class Program
    {
        static void Main()
        {
            Osoba o = new Osoba("Adam", "Miś", "20.03.1988");
            Osoba o2 = new Student("Michał", "Kot", "13.04.1990", 2, 1, 12345);
            Osoba o3 = new Pilkarz("Mateusz", "Żbik", "10.08.1986", "obrońca", "FC Czestochowa");

            o.WypiszInfo();
            o2.WypiszInfo();
            o3.WypiszInfo();

            Student s = new Student("Krzysztof", "Jeż", "22.12.1990", 2, 5, 54321);
            Pilkarz p = new Pilkarz("Piotr", "Kos", "14.09.1984", "napastnik", "FC Politechnika");
            s.WypiszInfo();
            p.WypiszInfo();

            ((Pilkarz)o3).StrzelGola();
            p.StrzelGola();
            p.StrzelGola();

            o3.WypiszInfo();
            p.WypiszInfo();

            ((Student)o2).DodajOcene("PO", "20.02.2011", 5.0);
            ((Student)o2).DodajOcene("Bazy danych", "13.02.2011", 4.0);

            o2.WypiszInfo();

            s.DodajOcene("Bazy danych", "01.05.2011", 5.0);
            s.DodajOcene("AWWW", "11.05.2011", 5.0);
            s.DodajOcene("AWWW", "02.04.2011", 4.5);

            s.WypiszInfo();

            s.UsunOcene("AWWW", "02.04.2011", 4.5);

            s.WypiszInfo();

            s.DodajOcene("AWWW", "02.04.2011", 4.5);
            s.UsunOcene("AWWW");

            s.WypiszInfo();

            s.DodajOcene("AWWW", "02.04.2011", 4.5);
            s.UsunOceny();

            s.WypiszOceny();

            s.DodajOcene("Matematyka", "10.04.2022", 5);
            s.DodajOcene("Bazy danych", "01.05.2011", 5.0);
            s.DodajOcene("Matematyka", "11.04.2022", 4.5);
            s.DodajOcene("Historia", "11.05.2011", 5.0);
            s.DodajOcene("Matematyka", "12.04.2022", 4);
            s.DodajOcene("Programowanie obiektowe", "02.04.2011", 4.5);

            s.WypiszOceny("Matematyka");

            Console.ReadKey();
        }
    }
}
