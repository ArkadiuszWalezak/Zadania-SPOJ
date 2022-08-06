using System;
using System.Collections.Generic;
using System.Linq;

namespace LaborkiPO02
{
    public class Student : Osoba
    {
        private int rok;
        private int grupa;
        private int nrIndeksu;
        private List<Ocena> oceny = new List<Ocena>();

        public Student() {}

        public Student(string imie, string nazwisko, string dataUrodzenia, int rok, int grupa, int nrIndeksu)
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
            this.dataUrodzenia = dataUrodzenia;
            this.rok = rok;
            this.grupa = grupa;
            this.nrIndeksu = nrIndeksu;
        }

        public void DodajOcene(string nazwaPrzedmiotu, string data, double wartos)
        {
            Ocena o = new Ocena(nazwaPrzedmiotu,data,wartos);
            oceny.Add(o);
        }

        public void WypiszOceny()
        {
            //for (int i = 0; i < oceny.Count; i++)
            //{
            //    Ocena o = oceny[i];
            //    o.WypiszInfo();
            //}

            foreach (Ocena o in oceny)
            {
                o.WypiszInfo();
            }
        }

        public void WypiszOceny(string nazwaPrzedmiotu)
        {
            //for (int i = 0; i < oceny.Count; i++)
            //{
            //    Ocena o = oceny[i];
            //    if (o.NazwaPrzedmiotu == nazwaPrzedmiotu)
            //    {
            //        oceny[i].WypiszInfo();
            //    }
            //}

            //foreach (Ocena o in oceny.Where(x => x.NazwaPrzedmiotu == nazwaPrzedmiotu).ToList())
            //{
            //    o.WypiszInfo();
            //}

            foreach (Ocena o in oceny)
            {
                if (o.NazwaPrzedmiotu == nazwaPrzedmiotu)
                {
                    o.WypiszInfo();
                }
            }
        }

        public void UsunOcene(string nazwaPrzedmiotu, string data, double wartosc)
        {
            for (int i = 0; i < oceny.Count; i++)
            {
                Ocena o = oceny[i];
                if (o.NazwaPrzedmiotu == nazwaPrzedmiotu && o.Data == data && o.Wartosc == wartosc)
                {
                    //oceny.RemoveAt(i);
                    oceny.Remove(o);
                }
            }
        }

        //public void Test(string x, string y, int version)
        //{
        //    //Defense programming = zabezpieczenie przed niepoprawnymi wartosciami juz na początku metody tak, żeby w przypadku nieprawidłowych danych wejrsciowych podjąć odpowiednie //kroki np: zakonczyc działanie programu. Poniżej przykladowe zabezpieczenie w stylu "defense programming"
        //    if (string.IsNullOrWhiteSpace(x))
        //    {
        //        //throw w przeciwienstwie do returna zakonczy dzialanie programu z komunikatem wyjątku
        //        throw new Exception("blabla");
        //    }
        //
        //    if (string.IsNullOrWhiteSpace(y))
        //    {
        //        //zwykly return zakonczy dzialanie danej metody
        //        Console.WriteLine("blabla");
        //        return;
        //    }
        //
        //    if (version < 1)
        //    {
        //        Console.WriteLine("blabla");
        //        return;
        //    }
        //
        //    // --- przykladowe akcje ktore powinna wykonywac poprawna metoda Test ---
        //    //wpiszDoBazy(x);
        //    //wpiszDoBazy(y);
        //    //version += 1;
        //    // ----------------------------------------------------------------------
        //
        //
        //    // --- przyklad poprawnego bloku try catch ktory obsluguje wyjatek w przypadku jego wystapienia
        //    //    string x;
        //    //    int y;
        //    //
        //    //    try
        //    //    {
        //    //        x = "exampleText";
        //    //        y = int.Parse(x);
        //    //    }
        //    //    catch (Exception e)
        //    //    {
        //    //        Console.WriteLine(e.Message);
        //    //    }
        //}

        public void UsunOcene(string nazwaPrzedmiotu)
        {
            for (int i = 0; i < oceny.Count; i++)
            {
                Ocena o = oceny[i];
                if (o.NazwaPrzedmiotu == nazwaPrzedmiotu)
                {
                    //oceny.RemoveAt(i);
                    oceny.Remove(o);
                }
            }
        }

        public void UsunOceny()
        {
            oceny.Clear();
        }

        public override void WypiszInfo()
        {
            Console.WriteLine(imie + " " + nazwisko + " " + dataUrodzenia + " " + rok + " " + grupa + " " + nrIndeksu);
            
            for (int i = 0; i < oceny.Count; i++)
            {
                oceny[i].WypiszInfo();
            }
        }
    }
}
