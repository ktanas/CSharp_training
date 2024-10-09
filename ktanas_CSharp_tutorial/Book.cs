using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ktanas_CSharp_tutorial
{
    class Book
    {
        public string title;
        public string author;
        public int pages;

        public Book(string name, string writer, int numberOfPages)
        {
            this.title = name;
            this.author = writer;
            this.pages = numberOfPages;
        }
    }
}
