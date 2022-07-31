using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaborkiPO03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ksiazka k = new Ksiazka("Harry Potter", 1, "Media Rodzina", 2001, 500);

            Katalog katalog = new Katalog("Fantastyka");

            katalog.DodajPozycje("Rok 1984",1,"blabla",1970,300);

            k.WypiszInfo();

            k.DodajAutora("J.K", "Rowling");

            k.WypiszInfo();

            katalog.WypiszWszystkiePozycje();


            

            Console.ReadLine();
        }
    }
}
