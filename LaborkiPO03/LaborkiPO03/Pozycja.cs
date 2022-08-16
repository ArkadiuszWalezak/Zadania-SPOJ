using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaborkiPO03
{
    public abstract class Pozycja
    {
        protected string tytul;
        public string Tytul => tytul;

        protected int id;
        public int Id => id;

        protected string wydawnictwo;
        protected int rokWydania;

        public Pozycja() { }

        public Pozycja (string tytul, int id, string wydawnictwo, int rokWydania)
        {
            this.tytul = tytul;
            this.id = id;
            this.wydawnictwo = wydawnictwo;
            this.rokWydania = rokWydania;
        }

        public abstract void WypiszInfo();
    }
}
