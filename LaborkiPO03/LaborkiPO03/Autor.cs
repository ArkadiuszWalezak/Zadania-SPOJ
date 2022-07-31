using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaborkiPO03
{
    public class Autor
    {
        private string imie;

        public string Imie 
        { 
            get { return imie; } 
            set { imie = value; } 
        }
        
        private string nazwisko;
        public string Nazwisko
        {
            get { return nazwisko; }
            set { nazwisko = value; }
        }

        public Autor() { }

        public Autor(string imie, string nazwisko)
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
        }
    }
}
