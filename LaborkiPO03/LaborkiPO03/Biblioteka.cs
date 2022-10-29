using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace LaborkiPO03
{
    public class Biblioteka : IZarzadzaniePozycjami
    {
        private string adres;

        public List<Katalog> biblioteka = new List<Katalog>();

        public List<Bibliotekarz> bibliotekarze = new List<Bibliotekarz>();

        public Bibliotekarz zalogowanyBibliotekarz;

        public Biblioteka() { }

        public Biblioteka (string adres)
        {
            this.adres = adres;
        }

        public Pozycja ZnajdzPozycjePoTytule(string tytul)
        {
            foreach (var katalog in biblioteka)
            {
                return katalog.ZnajdzPozycjePoTytule(tytul);
            }
            return null;
        }
        
        public void UsunKatalog(string dzialTematyczny)
        {
            foreach (var katalog in biblioteka)
            {
                if (katalog.DzialTematyczny == dzialTematyczny)
                {
                    biblioteka.Remove(katalog);
                }
            }
        }

        public Pozycja ZnajdzPozycjePoId(int id)
        {
            foreach (var katalog in biblioteka)
            {
                return katalog.ZnajdzPozycjePoId(id);
            }
            return null;
        }

        public void WypiszWszystkiePozycje()
        {
            foreach (var katalog in biblioteka)
            {
                katalog.WypiszWszystkiePozycje();
            }
        }

        public void DodajKatalog(Katalog k)
        {
            biblioteka.Add(k);
        }

        public void DodajPozycje(Pozycja p, string dzialTematyczny)
        {
            foreach (var katalog in biblioteka)
            {
                if (katalog.DzialTematyczny == dzialTematyczny)
                {
                    katalog.DodajPozycje(p);
                    return;
                }
            }
        }

        public List<Pozycja> WyszkuajZ(string slowo)
        {
            var list = new List<Pozycja>();
            foreach (var katalog in biblioteka)
            {
                list.AddRange(katalog.WyszukajZ(slowo));
            }
            return list;
        }

        public void DodajBibliotekarza(Bibliotekarz b)
        { 
            if (!bibliotekarze.Contains(b))
            {
                bibliotekarze.Add(b);
            }
        }

        public void WypiszBibliotekarzy()
        {
            for (int i = 0; i < bibliotekarze.Count; i++)
            {
                Console.Write($"[{i + 1}] - "); 
                bibliotekarze[i].WypiszInfo(); 
            }
        }

        public void Start()
        {
            Console.WriteLine("Witaj. Wybierz konto: ");
            Console.WriteLine("----------------------");
            WypiszBibliotekarzy();

            Logowanie();
        }

        private Bibliotekarz ZalogujSieNaBibliotekarza(int numerBibliotekarza)
        {
            return bibliotekarze[numerBibliotekarza];
        }

        private void Logowanie()
        {
            try
            {
                int numerBibliotekarza = int.Parse(Console.ReadLine());
                zalogowanyBibliotekarz = ZalogujSieNaBibliotekarza(numerBibliotekarza - 1);
                WyswietlEkranPowitalny();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Naciśnij enter żeby zrestatować.");
                Console.ReadKey();
                Console.Clear();
                Start();
            }
        }

        private void WyswietlEkranPowitalny()
        {
            Console.Clear();
            Console.WriteLine("Witaj " + zalogowanyBibliotekarz.Imie + ' ' + zalogowanyBibliotekarz.Nazwisko);
            Thread.Sleep(0000);
            Console.WriteLine("Wybierz, jaką czynność chcesz wykonać: ");
            Thread.Sleep(0000);
            Console.WriteLine("1. Operacje na katalogach");
            Thread.Sleep(0000);
            Console.WriteLine("2. Dodać/Usunąc pozycje w danym katalogu");
            Thread.Sleep(0000);
            Console.WriteLine("3. Dodaj autora");
            Console.WriteLine("4. Wylogowanie");

            try
            {
                int numerCzynnosci = int.Parse(Console.ReadLine());
                if (numerCzynnosci == 1)
                {
                    DodajKatalog();
                }
                else if (numerCzynnosci == 2)
                {
                    OperacjaNaKsiazkach();
                }
                else if (numerCzynnosci == 3)
                {
                    DodajAutora();
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Do zobaczenia " + zalogowanyBibliotekarz.Imie + ' ' + zalogowanyBibliotekarz.Nazwisko);
                    Console.ReadKey();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Naciśnij enter żeby zrestatować.");
                Console.ReadKey();
                Console.Clear();
                WyswietlEkranPowitalny();
            }
        }

        private void DodajKatalog()
        {
            Console.Clear();
            Console.WriteLine("Oto istniejące katalogi: ");
            
            for (int i = 0; i < biblioteka.Count; i++)
            {
                Console.Write($"[{i + 1}] - ");
                biblioteka[i].WypiszInfo();
            }
            Thread.Sleep(1500);
            Console.WriteLine("Jakie czynności na katalogach chcesz wykonać?");
            Console.WriteLine("1. Dodaj nowy katalog");
            Console.WriteLine("2. Usuń katalog");
            Console.WriteLine("3. Wyświetl pozycje w danym katalogu");
            
            Console.WriteLine("4. Wyjdź do ekranu powitalnego");

            int numerCzynnosci = int.Parse(Console.ReadLine());

            
            if (numerCzynnosci == 1)
            {
                Console.WriteLine("Podaj nazwe nowego katalogu: ");
                string xd = Console.ReadLine();
                biblioteka.Add(new Katalog (xd));
                DodajKatalog();
            }
            
            if (numerCzynnosci == 2)
            {
                Console.WriteLine("Podaj nazwe katalogu który chcesz usunąć: ");
                string xd = Console.ReadLine();
                UsunKatalog(xd);
            }

            if(numerCzynnosci == 3)
            {
                WyswietlPozycjeWKatalogu();
            }

            else
            {
                WyswietlEkranPowitalny();
            }
        }

        private void OperacjaNaKsiazkach()
        {
            Console.Clear();

            Console.WriteLine("Jaką operację chcesz wykonać:");
            Console.WriteLine("1. Dodaj pozycje");
            Console.WriteLine("2. Usuń pozycje");
            Console.WriteLine("3. Wróć do ekranu powitalnego");

            int numerCzynnosci1 = int.Parse(Console.ReadLine());

            if (numerCzynnosci1 == 1)
                {
                DodajKsiazke();
                }
            if (numerCzynnosci1 == 2)
            {
                UsunKsiazke();
            }
            else
            {
                WyswietlEkranPowitalny();
            }
        }

        public void DodajKsiazke()
        {
            Console.WriteLine("Oto istniejące katalogi: ");

            for (int i = 0; i < biblioteka.Count; i++)
            {
                Console.Write($"[{i + 1}] - ");
                biblioteka[i].WypiszInfo();
            }
            Thread.Sleep(1500);
            Console.WriteLine("W którym katalogu chciałbyś dodać pozycje?");

            int numerCzynnosci = int.Parse(Console.ReadLine());

            Console.WriteLine("Podaj tytuł pozycji: ");
            string tytul = Console.ReadLine();
            Console.WriteLine("Podaj numer pozycji: ");
            int.TryParse(Console.ReadLine(), out int id);
            Console.WriteLine("Podaj wydawnictwo pozycji: ");
            string wydawnictwo = Console.ReadLine();
            Console.WriteLine("Podaj rok wydania pozycji: ");
            int.TryParse(Console.ReadLine(), out int rokWydania); 
            Console.WriteLine("Podaj liczbe stron pozycji: ");
            int.TryParse(Console.ReadLine(), out int liczbaStron);

            biblioteka[numerCzynnosci - 1].DodajPozycje(tytul, id, wydawnictwo, rokWydania, liczbaStron);

            OperacjaNaKsiazkach();
        }

        public void UsunKsiazke()
        {
            Console.WriteLine("Oto istniejące katalogi: ");

            for (int i = 0; i < biblioteka.Count; i++)
            {
                Console.Write($"[{i + 1}] - ");
                biblioteka[i].WypiszInfo();
            }
            Thread.Sleep(1500);
            Console.WriteLine("W którym katalogu chciałbyś usunąć pozycje?");
            int numerCzynnosci = int.Parse(Console.ReadLine());

            if (biblioteka[numerCzynnosci - 1].DzialTematyczny.Any() == false)
                
            {
                Console.WriteLine("Wybrana biblioteka jest pusta. Nastąpi przejscie do ekranu powitalnego");
                Console.ReadKey();
                WyswietlEkranPowitalny();
            }

            else
            {
                Console.WriteLine("W katalogu " + biblioteka[numerCzynnosci - 1].DzialTematyczny + " występują stępujące pozycje: ");
                biblioteka[numerCzynnosci - 1].WypiszWszystkiePozycje();

                Console.WriteLine("Jaki tytuł ma książka która chcesz usunąć");
                string tytulDoUsuniecia = Console.ReadLine();
                biblioteka[numerCzynnosci - 1].UsunPozycje(tytulDoUsuniecia);
            }
        }

        public void WyswietlPozycjeWKatalogu()
        {
            Console.Clear();

            Console.WriteLine("Oto istniejące katalogi: ");

            for (int i = 0; i < biblioteka.Count; i++)
            {
                Console.Write($"[{i + 1}] - ");
                biblioteka[i].WypiszInfo();
            }
            Thread.Sleep(1000);
            Console.WriteLine("W którym katalogu chciałbyś wypisać pozycje?");
            int.TryParse(Console.ReadLine(), out int numerCzynnosci);
            Console.WriteLine("W katalogu " + biblioteka[numerCzynnosci - 1].DzialTematyczny + " występują stępujące pozycje: "); 
            biblioteka[numerCzynnosci - 1].WypiszWszystkiePozycje();

            Console.WriteLine("Aby wyjść do ekranu powitalnego, nacisnij enter.");
            Console.ReadKey();
            WyswietlEkranPowitalny();
        }

        private void DodajAutora()
        {
            Console.WriteLine("Tu będzie można dodawać autorów and shit");
            Thread.Sleep(3000);
            WyswietlEkranPowitalny();
        }

    }
}
