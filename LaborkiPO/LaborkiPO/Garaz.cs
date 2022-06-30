using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaborkiPO
{
    public class Garaz
    {
        private string adres
        {
            set { adres = value;}
            get { return adres; }
        }
        private int pojemnosc
        {
            set 
            { 
                pojemnosc = value;
                samochody = new Samochod[pojemnosc];
            }
            
            get { return pojemnosc; }
        }

        private Samochod[] samochody;
        private int liczbaSamochodow = 0;

        public Garaz()
        {
            adres = "nieznany";
            pojemnosc = 0;
            samochody = null;
        }

        public Garaz (string adres, int pojemnosc)
        {
            this.adres = adres;
            this.pojemnosc = pojemnosc;
            samochody = new Samochod[pojemnosc];
        }

        public void WprowadzSamochod(Samochod samochod)
        {
            if (pojemnosc == liczbaSamochodow)
            {
                Console.WriteLine("Garaż pełny.");
            }

            else
            {
                samochod = samochody[liczbaSamochodow];
                liczbaSamochodow++;
            }

            Console.WriteLine("Liczba wolnych miejsc postojowych {0}/{1}",liczbaSamochodow,pojemnosc);
            
        }

        public Samochod WyprowadzSamochod()
        {
            if (pojemnosc == 0)
            {
                Console.WriteLine("Garaż jest pusty.");
            }
            else
            {
                samochody[liczbaSamochodow] = null;
                liczbaSamochodow--;
            }
            return Samochod

        }

    }
}
