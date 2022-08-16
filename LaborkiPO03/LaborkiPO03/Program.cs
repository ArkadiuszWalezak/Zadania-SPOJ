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


            Biblioteka biblioteka = new Biblioteka();
            biblioteka.DodajBibliotekarza(new Bibliotekarz("Jan", "Kowalski", "1.2.3", 500));
            biblioteka.DodajBibliotekarza(new Bibliotekarz("Józef", "Bąk", "1.2.3", 600));

            Katalog k1 = new Katalog("Fantastyka");
            Katalog k2 = new Katalog("Przyrodniczy");
            Katalog k3 = new Katalog("Kulinarny");
            Katalog k4 = new Katalog("Sportowy");

            biblioteka.DodajKatalog(k1);
            biblioteka.DodajKatalog(k2);
            biblioteka.DodajKatalog(k3);
            biblioteka.DodajKatalog(k4);

            k1.DodajPozycje(new Ksiazka("Harry Potter1", 1, "Media Rodzina", 2001, 500));

            biblioteka.Start();

            
            //
            //k1.DodajPozycje(new Ksiazka("Harry Potter1", 1, "Media Rodzina", 2001, 500));
            //k1.DodajPozycje(new Ksiazka("Rok 1984", 1, "blabla", 1970, 300));
            //k1.DodajPozycje(new Czasopismo("Rok 1984", 1, "kkokoko", 1970, 300));
            //
            //k2.DodajPozycje(new Ksiazka("Harry Potter2", 1, "Media Rodzina", 2001, 500));
            //k2.DodajPozycje(new Ksiazka("Rok 1984", 1, "blabla", 1970, 300));
            //k2.DodajPozycje(new Czasopismo("Rok 1984", 1, "kkokoko", 1970, 300));
            //
            //k3.DodajPozycje(new Ksiazka("Harry Potter3", 1, "Media Rodzina", 2001, 500));
            //k3.DodajPozycje(new Ksiazka("Rok 1984", 1, "blabla", 1970, 300));
            //k3.DodajPozycje(new Czasopismo("Rok 1984", 1, "kkokoko", 1970, 300));
            //
            //k4.DodajPozycje(new Ksiazka("Harry Potter41", 1, "Media Rodzina", 2001, 500));
            //k4.DodajPozycje(new Ksiazka("Harry Potter42", 1, "Media Rodzina", 2001, 500));
            //k4.DodajPozycje(new Ksiazka("Harry Potter43", 1, "Media Rodzina", 2001, 500));
            //k4.DodajPozycje(new Ksiazka("Rok 1984", 1, "blabla", 1970, 300));
            //k4.DodajPozycje(new Czasopismo("Rok 1984", 1, "kkokoko", 1970, 300));
            //
            //var pozycjaTest1 = b.ZnajdzPozycjePoTytule("Harry Potter1");
            //var znajdzTest1 = b.WyszkuajZ("Harry");
            //var znajdzTest2 = b.WyszkuajZ("harry");

            //k.WypiszInfo();
            //
            //Autor a = new Autor("J.K", "Rowling", "Narodowość");
            //k.DodajAutora(a);
            //
            //k.WypiszInfo();
            //
            //katalog.WypiszWszystkiePozycje();

            Console.ReadLine();
        }
    }
}
