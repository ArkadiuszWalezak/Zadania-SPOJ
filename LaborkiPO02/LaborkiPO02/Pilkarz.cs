using System;

namespace LaborkiPO02
{
    public class Pilkarz : Osoba
    {
        protected string pozycja;
        protected string klub;
        private int liczbaGoli = 0;

        public Pilkarz() { }

        public Pilkarz(string imie, string nazwisko, string dataUrodzenia, string pozycja, string klub)
        {
            this.pozycja = pozycja;
            this.klub = klub;
            this.imie = imie;
            this.nazwisko = nazwisko;
            this.dataUrodzenia = dataUrodzenia;
        }

        public virtual void StrzelGola()
        {
            liczbaGoli++;
        }

        public override void WypiszInfo()
        {
            Console.WriteLine(imie + " " + nazwisko + " " + dataUrodzenia + " " + klub + " " + pozycja + " no i typ strzelił: " + liczbaGoli);
        }
    }
}
