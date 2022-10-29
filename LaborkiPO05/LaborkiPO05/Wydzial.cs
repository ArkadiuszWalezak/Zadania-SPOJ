using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaborkiPO05
{
    public class Wydzial
    {
        public List<Wydzial> wydzial = new  List<Wydzial>();

        public void DodajJednostke(string nazwa, string adres)
        {

        }

        public void DodajPrzedmiot(Przedmiot p)
        {
             
        }

        public void DodajStudenta(Student s)
        {

        }

        public bool DodajWykladowce(Wykladowca w, string nazwaJednostki)
        {
            return false;
        }

        public bool InfoStudenci()
        {
            return true;
        }

        public bool InfoJednostki()
        {
            return true;
        }

        public void InfoPrzedmioty()
        {

        }

        public bool DodajOcene(int nrIndeksu, string nazwaPrzedmiotu, int ocena, string data)
        {
            return false;
        }

        public bool UsunStudenta(int nrIndeksu)
        {
            return false;
        }

        public bool PrzeniesWykladowce(Wykladowca w, string obecnaJednostka, string nowaJednostka)
        {
            return false;
        }
    }
}
