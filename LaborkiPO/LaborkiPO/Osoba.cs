using System;

namespace LaborkiPO
{
    public class Osoba
    {
        public string imie;
        public string nazwisko;
        public string adresZamieszkania;
        public int iloscSamochodow = 0;
        private string[] numeryRejestracyjne;
        public Osoba()
        {
            imie = "nieznane";
            nazwisko = " nieznane";
            adresZamieszkania = "nieznany";
            iloscSamochodow = 0;
        }

        public Osoba (string imie, string nazwisko, string adresZamieszkania, int iloscSamochodow)
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
            this.adresZamieszkania = adresZamieszkania;
            numeryRejestracyjne = new string[3];
        }

        public void DodajSamochod(string numerRejestracyjny)
        {
            if (iloscSamochodow == 3)
            {
                Console.WriteLine("Ilość maksymalna samochodów osiągnięta"); 
            }
            else
            {
                numeryRejestracyjne = numerRejestracyjny;
                iloscSamochodow++;
            }
        }
    }
}
