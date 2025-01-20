using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_Library
{
    internal class Book
    {
        public string Author { get; set; }

        public string Title { get; set; }
        public int Pages { get; set; }
        public bool Available { get; set; }

        public Book(string author, string title, int pages)
        {
            this .Author = author;
            this .Title = title;
            this .Pages = pages;
            this.Available = true;
        }

        public string Info
        {
            get
            {
                return $"{Title}; {Author}; Pages={Pages}; Available={Available}";
            }
        }
    }
}
