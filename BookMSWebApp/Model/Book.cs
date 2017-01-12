using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookMSWebApp.Model
{
    public class Book
    {
        public int Serial { get; set; }
        public string ISBN { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }

        // Used to save data
        public Book(string isbn, string name, string author)
        {
            ISBN = isbn;
            Name = name;
            Author = author;
        }

        // Used to Get Data
        public Book(int serial, string isbn, string name, string author)
        {
            Serial = serial;
            ISBN = isbn;
            Name = name;
            Author = author;
        }
    }
}