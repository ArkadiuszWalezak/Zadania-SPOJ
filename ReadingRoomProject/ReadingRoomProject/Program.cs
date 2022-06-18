using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadingRoomProject
{
    public class Program
    {
        static void Main()
        {
            Person p1 = new Person("Arkadiusz", "Walezak", 30);
            Person p2 = new Person("Mateusz", "Gryboś", 26);
            Person p3 = new Person("Kinga", "Walezak", 29);

            Book b1 = new Book("Kroczac w ciemnosci", p1, DateTime.Now);
            Book b2 = new Book("Czerwien rubinu", new Person("Karl", "Gajger", 100), DateTime.Now);

            p1.Show();
            p2.Show();
            p3.Show();
            b1.Show();
            b2.Show();
            Console.ReadKey();

        }
    }
}
