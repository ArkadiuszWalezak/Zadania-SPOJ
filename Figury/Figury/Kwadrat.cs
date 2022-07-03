using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figury
{
    public class Kwadrat : Figura
    {
        private double bok;

        public Kwadrat(string nazwa, double bok) :
            base(nazwa)
        {
            this.bok = bok;
        }

        public override double ObliczPole()
        {
            Pole = bok * bok;
            return Pole;
        }
    }
}
