using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figury
{
    public class Kolo : Figura
    {
        private double promien;
        private const double PI = 3.14;

        public Kolo(string nazwa, double promien) : 
            base (nazwa)
        {
            this.promien = promien;
        }

        public override double ObliczPole()
        {
            Pole = PI * promien * promien;
            return Pole;
        }
    }
}
