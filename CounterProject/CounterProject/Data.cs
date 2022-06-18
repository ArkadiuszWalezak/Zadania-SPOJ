using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CounterProject
{
    public class Data
    {
        private DateTime CurrentDate;
        private string dateFormat;

        public Data(string dateFormat)
        {
            CurrentDate = DateTime.Now;
            this.dateFormat = dateFormat;
        }

        public void Odczyt()
        {
            Console.WriteLine(CurrentDate.ToString(dateFormat));
        }

        public void PrzesunWPrzod()
        {
            CurrentDate = CurrentDate.AddDays(7);
        }

        public void PrzesunWTyl()
        {
            CurrentDate = CurrentDate.AddDays(-7);
        }
    }
}
