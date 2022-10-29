using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaborkiPO05
{
    public class OcenaKoncowa : IInfo
    {
        private double wartosc = 0.0;
        private string data = "";

        public OcenaKoncowa(double ocena, string data, Przedmiot d)
        {
            this.wartosc = ocena;
            this.data = data;
        }

        public void WypiszInfo()
        {

        }
    }
}
