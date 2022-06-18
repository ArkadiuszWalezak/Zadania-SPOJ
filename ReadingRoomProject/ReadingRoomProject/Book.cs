using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadingRoomProject
{
    public class Book
    {
        private string title;
        private Person author;
        private DateTime realiseDate;

        public Book(string title, Person author, DateTime dateTime)
        {
            this.title = title;
            this.author = author;
            realiseDate = dateTime;
        }

        public void Show()
        {
            Console.WriteLine($"Book: \n\t{title}, \n\tauthor: {author.GetInformation()}, \n\tTime of realise: {realiseDate}");
        }
    }
}
