using System;

namespace LaborkiPO02
{
    public class Pilkarz : Osoba
    {
        private string pozycja;
        private string klub;
        public int liczbaGoli = 0;

        public Pilkarz() { }

        public Pilkarz(string imie, string nazwisko, string dataUrodzenia, string pozycja, string klub)
        {
            this.pozycja = pozycja;
            this.klub = klub;
            this.imie = imie;
            this.nazwisko = nazwisko;
            this.dataUrodzenia = dataUrodzenia;
        }

        public void StrzelGola()
        {
            liczbaGoli++;
        }

        public override void WypiszInfo()
        {
            Console.WriteLine(imie + " " + nazwisko + " " + dataUrodzenia + " " + klub + " " + pozycja + " no i typ strzelił: " + liczbaGoli);
        }
    }
}
