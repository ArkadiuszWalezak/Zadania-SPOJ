using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaborkiPO02
{
    public class Ocena
    {
        private string nazwaPrzedmiotu;
        public string NazwaPrzedmiotu
        {
            get { return nazwaPrzedmiotu; }
            set { nazwaPrzedmiotu = value; }
        }

        private string data;
        public string Data
        {
            get { return data; }
            set { data = value; }
        }

        private double wartosc;
        public double Wartosc
        {
            get { return wartosc; }
            set { wartosc = value; }
        }

        public Ocena(string nazwaPrzedmiotu, string data, double wartosc)
        {
            this.nazwaPrzedmiotu = nazwaPrzedmiotu;
            this.data = data;
            this.wartosc = wartosc;
        }

        public void WypiszInfo()
        {
            Console.WriteLine(nazwaPrzedmiotu + " " + data + " " + wartosc);
        }
    }
}
