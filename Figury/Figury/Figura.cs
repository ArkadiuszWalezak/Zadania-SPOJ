using System;

namespace Figury
{
    public abstract class Figura
    {
        private string nazwa;
        private double pole;
        public double Pole
        {
            get { return pole; }
            set { pole = value; }
        }

        public Figura(string nazwa)
        {
            this.nazwa = nazwa;
        }

        public abstract double ObliczPole();
    
        public void WypiszPole()
        {
            Console.WriteLine(nazwa + ": " + pole);
        }
    }
}
