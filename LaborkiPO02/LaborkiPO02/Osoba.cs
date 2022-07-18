using System;

namespace LaborkiPO02
{
    public class Osoba
    {
        protected string imie;
        protected string nazwisko;
        protected string dataUrodzenia;

        public Osoba() { }

        public Osoba (string imie, string nazwisko, string dataUrodzienia)
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
            this.dataUrodzenia = dataUrodzienia;
        }

        public virtual void WypiszInfo()
        {
            Console.WriteLine(imie + ' ' + nazwisko + ", urodzony: " + dataUrodzenia);
        }
    }
}
