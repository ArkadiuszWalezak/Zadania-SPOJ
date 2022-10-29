using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaborkiPO05
{
    public class Student : Osoba
    {
        private string kierunek = "";
        private string specjalnosc = "";
        private int rok = 0;
        private int grupa = 0;
        private int nrIndeksu = 0;

        public Student(string imie, string nazwisko, string dataUrodzenia, string kierunek, string specjalnosc, int rok, int grupa, int nrIndeksu) : base(imie, nazwisko, dataUrodzenia)
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
            this.dataUrodzenia = dataUrodzenia;
            this.kierunek = kierunek;
            this.specjalnosc = specjalnosc;
            this.rok = rok;
            this.nrIndeksu = nrIndeksu;
        }

        public new void WypiszInfo()
        {
            Console.WriteLine(imie + ' ' + nazwisko + ' ' + dataUrodzenia + ' ' + kierunek + ' ' + specjalnosc + ' ' + rok + ' ' + nrIndeksu);
        }

        public void InfoOceny()
        {

        }

        public bool DodajOcene(string nazwaPrzedmiotu, double ocena, string data)
        {
            
            return false;
        }
    }
}
