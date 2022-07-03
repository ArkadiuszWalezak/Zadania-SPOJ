using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaborkiPO
{
    public class OsobowySamochod : Samochod
    {
        public OsobowySamochod() : 
            base()
        {}

        public OsobowySamochod(string marka, string model, int iloscDrzwi, int pojemnoscSilnika, double srednieSpalanie) :
            base(marka, model, iloscDrzwi, pojemnoscSilnika, srednieSpalanie)
        {}
    }
}
