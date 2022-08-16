using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaborkiPO03
{
    public class Katalog : IZarzadzaniePozycjami
    {
        private string dzialTematyczny;

        public string DzialTematyczny
        {
            get { return dzialTematyczny; }
            set { dzialTematyczny = value; }
        }

        public List<Pozycja> katalog = new List<Pozycja>();

        public Katalog() { }

        public Katalog(string dzialTematyczny)
        {
            this.dzialTematyczny = dzialTematyczny;
        }

        public void WypiszInfo()
        {
            Console.WriteLine(dzialTematyczny);
        }

        public void DodajPozycje(Pozycja p)
        {
            katalog.Add(p);
        }

        public void DodajPozycje(string tytul, int id, string wydawnictwo, int rokWydania, int liczbaStron)
        {
            Pozycja p = new Ksiazka(tytul,id,wydawnictwo,rokWydania,liczbaStron);
            katalog.Add(p);
        }

        public void UsunPozycje(string tytul)
        {
            foreach (var blabla in katalog)
            {
                if (blabla.Tytul == tytul)
                {
                    katalog.Remove(blabla);
                }
            }
        }

        //Console.WriteLine(tytul + ' ' + id + ' ' + wydawnictwo + ' ' + rokWydania);

        public void WypiszWszystkiePozycje()
        {
            for (int i = 0; i < katalog.Count; i++)
            {
                katalog[i].WypiszInfo();
            }
        }

        public Pozycja ZnajdzPozycjePoTytule(string tytul)
        {
            foreach (var pozycja in katalog)
            {
                if (pozycja.Tytul == tytul)
                {
                    return pozycja;
                }
            }
            return null;
        }

        public Pozycja ZnajdzPozycjePoId(int id)
        {
            foreach (var pozycja in katalog)
            {
                if (pozycja.Id == id)
                {
                    return pozycja;
                }
            }
            return null;
        }

        public List<Pozycja> WyszukajZ(string slowo)
        {
            var list = new List<Pozycja>();
            foreach (var pozycja in katalog)
            {
                if (pozycja.Tytul.ToLower().Contains(slowo.ToLower()))
                {
                    if (!list.Contains(pozycja))
                    {
                        list.Add(pozycja);
                    }
                }
            }
            return list;
        }
    }
}
