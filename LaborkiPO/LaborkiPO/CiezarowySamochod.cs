using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaborkiPO
{
    public class CiezarowySamochod : Samochod
    {
        public int ladownosc = 0;

        public CiezarowySamochod() :
            base()
        { }

        public CiezarowySamochod(string marka, string model, int iloscDrzwi, int pojemnoscSilnika, double srednieSpalanie, int ladownosc) :
            base(marka, model, iloscDrzwi, pojemnoscSilnika, srednieSpalanie)
        {
            this.ladownosc = ladownosc;
        }
    }
}

