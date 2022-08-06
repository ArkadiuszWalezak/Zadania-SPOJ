using System;

namespace LaborkiPO02
{
    public class PilkarzReczny : Pilkarz
    {
        public PilkarzReczny(string imie, string nazwisko, string dataUrodzenia, string pozycja, string klub)
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
            this.dataUrodzenia = dataUrodzenia;
            this.pozycja = pozycja;
            this.klub = klub;
        }

        public override void StrzelGola()
        {
            base.StrzelGola();
            Console.WriteLine("Ręczny strzelił!");
        }
    }
}