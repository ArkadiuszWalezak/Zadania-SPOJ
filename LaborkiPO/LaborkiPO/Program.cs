﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaborkiPO
{
    public class Program
    {
        static void Main()
        {
            //--------ZAD 1--------
            //Samochod s1 = new Samochod();
            //s1.WypiszInfo();

            //s1.marka = "Fiat";
            //s1.model = "126p";
            //s1.iloscDrzwi = 2;
            //s1.pojemnoscSilnika = 650;
            //s1.srednieSpalanie = 6.0;
            //s1.WypiszInfo();

            //Samochod s2 = new Samochod("Syrena", "105", 2, 800, 7.6);

            //s2.WypiszInfo();

            //double kosztPrzejazdu = s2.ObliczKosztPrzejazdu(30.5, 4.85);
            //Console.WriteLine("Koszt przejazdu: " + kosztPrzejazdu);

            //Samochod.WypiszIloscSamochodow();

            //Console.ReadKey();

            //--------ZAD 2--------
            Samochod s1 = new OsobowySamochod("Fiat", "126p", 2, 650, 6.0);
            CiezarowySamochod s2 = new CiezarowySamochod("Syrena", "105", 2, 800, 7.6, 800);
            Garaz g1 = new Garaz();
            g1.Adres = "ul. Garażowa 1";
            g1.Pojemnosc = 1;
            Garaz g2 = new Garaz("ul. Garażowa 2", 2);
            g1.WprowadzSamochod(s1);
            g1.WypiszInfo();
            g1.WprowadzSamochod(s2);
            g2.WprowadzSamochod(s2);
            g2.WprowadzSamochod(s1);
            g2.WypiszInfo();

            g2.WyprowadzSamochod();
            g2.WypiszInfo();

            g2.WyprowadzSamochod();
            g2.WyprowadzSamochod();
            Console.ReadKey();
        }
    }
}
