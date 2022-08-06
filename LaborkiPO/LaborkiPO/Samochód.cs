using System;

namespace LaborkiPO
{
    public abstract class Samochod
    {
        public string marka;
        public string model;
        public int iloscDrzwi;
        public int pojemnoscSilnika;
        public double srednieSpalanie;
        private static int iloscSamochodów = 0;
        public string numerRejestracyjny;

        public Samochod()
        {
            marka = "nieznany";
            model = "nieznany";
            iloscDrzwi = 0;
            pojemnoscSilnika = 0;
            srednieSpalanie = 0.0;
            iloscSamochodów++;
        }

        public Samochod(string marka, string model, int iloscDrzwi, int pojemnoscSilnika, double srednieSpalanie, string numerRejestracyjny)
        {
            this.marka = marka;
            this.model = model;
            this.iloscDrzwi = iloscDrzwi;
            this.pojemnoscSilnika = pojemnoscSilnika;
            this.srednieSpalanie = srednieSpalanie;
            this.numerRejestracyjny = numerRejestracyjny;
            iloscSamochodów++;
        }

        public double ObliczSpalanie(double dlugoscTrasy) 
        {
            double x = dlugoscTrasy * srednieSpalanie / 100;
            double dziedziczonko = x;
            return x;
        }

        public double ObliczKosztPrzejazdu(double dlugoscTrasy, double cenaPaliwa)
        {
            double x = dlugoscTrasy * srednieSpalanie * 0.01 * cenaPaliwa;
            return x;
        }

        public void WypiszInfo()
        {
            Console.WriteLine("Marka: {0}, model: {1}, ilość drzwi = {2}, pojemność silnika = {3}, srednieSpalanie = {4}", marka, model, iloscDrzwi, pojemnoscSilnika, srednieSpalanie);
        }

        public static void WypiszIloscSamochodow()
        {
            Console.WriteLine(iloscSamochodów);
        }
    }
}
