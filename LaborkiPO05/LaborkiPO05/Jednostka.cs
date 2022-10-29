using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaborkiPO05
{
    public class Jednostka : IInfo
    {
        private string nazwa = "";
        private string adres = "";

        public Jednostka (string nazwa, string adres)
        {
            this.nazwa = nazwa;
            this.adres = adres;
        }

        public void DodajWykladowce(Wykladowca w)
        {

        }

        public bool UsunWykladowce(Wykladowca w)
        {
            return false;
        }

        public bool UsunWykladowce(string imie, string nazwisko)
        {
            return true;
        }

        public void InfoWykladowcy()
        {

        }

        public void WypiszInfo()
        {

        }
    }
}
