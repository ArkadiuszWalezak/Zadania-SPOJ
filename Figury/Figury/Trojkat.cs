using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figury
{
    public class Trojkat : Figura
    {
        private double podstawa;
        private double wysokosc;

        public Trojkat(string nazwa, double podstawa, double wysokosc) :
            base(nazwa)
        {
            this.podstawa = podstawa;
            this.wysokosc = wysokosc;
        }

        public override double ObliczPole()
        {
            Pole = 0.5 * wysokosc * podstawa;
            return Pole;
        }

    }
}
