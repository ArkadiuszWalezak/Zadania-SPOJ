using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaborkiPO05
{
    public class Wykladowca : Osoba
    {
        private string tytulNaukowy = "";
        private string stanowisko = "";
        
        public Wykladowca(string imie, string nazwisko, string tytulNaukowy, string stanowisko, string dataUrodzenia) : base(imie, nazwisko, dataUrodzenia)
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
            this.tytulNaukowy = tytulNaukowy;
            this.stanowisko = stanowisko;
            this.dataUrodzenia = dataUrodzenia;
        }

        public new void WypiszInfo()
        {

        }
    }
}
