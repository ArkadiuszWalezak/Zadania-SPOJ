using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaborkiPO05
{
    public class Przedmiot : IInfo
    {
        string nazwa = "";
        string kierunek = "";
        string specjalnosc = "";
        int semestr = 0;
        int ileGodzin = 0;

        public Przedmiot (string nazwa, string kierunek, string specjalnosc, int semestr, int ileGodzin)
        {
            this.nazwa = nazwa;
            this.kierunek = kierunek;
            this.specjalnosc = specjalnosc;
            this.semestr = semestr;
            this.ileGodzin = ileGodzin;
        }

        public void WypiszInfo()
        {

        }
    }
}
