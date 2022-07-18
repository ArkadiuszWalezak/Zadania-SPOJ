using System;
using System.Collections.Generic;

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
            for (int i = 0; i < oceny.Count; i++)
            {
                Ocena o = oceny[i];
                Console.WriteLine(o);
            }
        }

        public void WypiszOceny(string nazwaPrzedmiotu)
        {
            for (int i = 0; i < oceny.Count;)
            {
                Ocena o = oceny[i];
                if (o.NazwaPrzedmiotu == nazwaPrzedmiotu)
                {
                    Console.WriteLine(oceny[i]);
                }
                else
                {
                    i++;
                }
            }
        }
        public void UsunOcene(string nazwaPrzedmiotu, string data, double wartosc)
        {
            for (int i = 0; i < oceny.Count;)
            {
                Ocena o = oceny[i];
                if (o.NazwaPrzedmiotu == nazwaPrzedmiotu && o.Data == data && o.Wartosc == wartosc)
                {
                    oceny.RemoveAt(i);
                }
                else
                {
                    i++;
                }
            }
        }

        public void UsunOcene(string nazwaPrzedmiotu)
        {
            for (int i = 0; i < oceny.Count;)
            {
                Ocena o = oceny[i];
                if (o.NazwaPrzedmiotu == nazwaPrzedmiotu)
                {
                    oceny.RemoveAt(i);
                }
                else
                {
                    i++;
                }
            }
        }

        public void UsunOcene()
        {
            oceny.Clear();
        }

        public override void WypiszInfo()
        {
            Console.WriteLine(imie + " " + nazwisko + " " + dataUrodzenia + " " + rok + " " + grupa + " " + nrIndeksu);
            
            for (int i = 0; i < oceny.Count; i++)
            {
                Console.WriteLine(oceny[i]);
            }
        }
    }
}
