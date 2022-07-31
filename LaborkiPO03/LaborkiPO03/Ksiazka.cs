using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaborkiPO03
{
    public class Ksiazka : Pozycja  
    {
        private int liczbaStron;
        public int LiczbaStron
        {
            get { return liczbaStron; }
            set { liczbaStron = value; }
        }
        private List<Autor> autorList = new List<Autor>();

        public Ksiazka() { }

        public Ksiazka(string tytul,int id,string wydawnictwo, int rokWydania, int liczbaStron)
        {
            this.tytul = tytul;
            this.id = id;
            this.wydawnictwo = wydawnictwo;
            this.rokWydania = rokWydania;
            this.liczbaStron = liczbaStron;
        }

        public void DodajAutora(string imie, string nazwisko)
        {
            Autor a = new Autor(imie, nazwisko);
            autorList.Add(a);
        }

        public override void WypiszInfo()
        {
            Console.WriteLine(tytul + ' ' + id + ' ' + wydawnictwo + ' ' + rokWydania + ' ' + liczbaStron);
            for (int i = 0; i < autorList.Count; i++)
            {
                Console.WriteLine(autorList[i].Imie + ' ' + autorList[i].Nazwisko);
            }
        }
    }
}
