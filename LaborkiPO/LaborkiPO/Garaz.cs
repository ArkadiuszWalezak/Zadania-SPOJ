using System;

namespace LaborkiPO
{
    public class Garaz
    {
        private Samochod[] samochody;
        private int liczbaSamochodow = 0;


        private string adres;
        public string Adres 
        {
            get { return adres; }
            set { adres = value;} 
        }

        private int pojemnosc;
        public int Pojemnosc
        {
            set 
            { 
                pojemnosc = value;
                samochody = new Samochod[pojemnosc];
            }
            get { return pojemnosc; }
        }

        

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
                samochody[liczbaSamochodow] = samochod;
                liczbaSamochodow++;
            }

            //Console.WriteLine("Liczba wolnych miejsc postojowych {0}/{1}", liczbaSamochodow, pojemnosc);
        }

        public Samochod WyprowadzSamochod()
        {
            Samochod x;

            if (liczbaSamochodow == 0)
            {
                Console.WriteLine("Garaż jest pusty.");
                x = null;
            }
            else
            {
                liczbaSamochodow--;
                x = samochody[liczbaSamochodow];
                samochody[liczbaSamochodow] = null;
            }

            return x;
        }
        public void WypiszInfo()
        {
            Console.WriteLine("Adres: {0}", adres);
            Console.WriteLine("Pojemnosc: {0}", pojemnosc);

            for (int i = 0; i < pojemnosc - 1; i++)
            {
                samochody[i].WypiszInfo();
            }
        }
    }
}
