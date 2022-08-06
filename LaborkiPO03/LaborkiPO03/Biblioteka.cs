using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaborkiPO03
{
    public class Biblioteka : IZarzadzaniePozycjami
    {
        private string adres;

        public List<Katalog> biblioteka = new List<Katalog>();

        public Biblioteka() { }

        public Biblioteka (string adres)
        {
            this.adres = adres;
        }


        public void ZnajdzPozycje()
        {

        }

        public void WypiszWszystkiePozycje()
        {

        }

        public void DodajKatalog(Katalog p.)
        {
          
            Katalog k = new Katalog(dzialTematyczny);
        }


    }
}
