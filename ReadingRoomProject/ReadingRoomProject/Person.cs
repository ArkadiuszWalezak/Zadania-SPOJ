using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadingRoomProject
{
    public class Person
    {
        private string name;
        private string surname;
        private int age;

        public Person(string name, string surname, int age)
        {
            this.name = name;
            this.surname = surname;
            this.age = age;
        }

        public string GetInformation()
        {
            return $"\n\t{name} \n\t{surname}, \n\tAge: {age}";
        }

        public void Show() 
        {
            Console.WriteLine("Person: " + GetInformation());
        }
    }
}
