using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaborkiPO03
{
    public class Katalog
    {
        private string dzialTematyczny;

        public string DzialTematyczny
        {
            get { return dzialTematyczny; }
            set { dzialTematyczny = value; }
        }

        private List<Pozycja> katalog = new List<Pozycja>();

        public Katalog() { }

        public Katalog(string dzialTematyczny)
        {
            this.dzialTematyczny = dzialTematyczny;
        }

        public void DodajPozycje(string tytul, int id, string wydawnictwo, int rokWydania, int liczbaStron)
        {
            Pozycja p = new Ksiazka(tytul,id,wydawnictwo,rokWydania,liczbaStron);
            katalog.Add(p);
        }

        public void WypiszWszystkiePozycje()
        {
            for (int i = 0; i < katalog.Count; i++)
            {
                Pozycja p = katalog[i];
                p.WypiszInfo();
            }
        }
        public void ZnajdzPozycje()
        {

        }
    }
}
