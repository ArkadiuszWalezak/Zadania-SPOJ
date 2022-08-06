using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaborkiPO02
{
    public class PilkarzNozny : Pilkarz
    {
        public PilkarzNozny (string imie, string nazwisko, string dataUrodzenia, string pozycja, string klub)
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
            Console.WriteLine("Nożny strzelił!");
        }
    }
}
