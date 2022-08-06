using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaborkiPO03
{
    public class Bibliotekarz : Osoba
    {
        private string dataZatrudnienia;
        private double wynagrodzenie;

        public Bibliotekarz() { }

        public Bibliotekarz(string imie, string nazwisko, string dataZatrudnienia, double wynagrodzenie)
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
            this.dataZatrudnienia = dataZatrudnienia;
            this.wynagrodzenie = wynagrodzenie;
        }
    }
}
