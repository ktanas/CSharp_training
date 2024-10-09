using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ktanas_CSharp_tutorial
{
    class Film
    {
        private string name;
        private string author;
        private int rating;
        private static int filmCount = 0;

        public Film(string name, string author, int rating)
        {
            this.name = name;
            this.author = author;
            this.rating = rating;
            filmCount++;
        }

        public int getFilmCount()
        {
            return filmCount;
        }

        public int Rating
        {
            get { return rating; }
            set {
                if ((value == 0) || (value == 100) || (value == 200))
                {
                    rating = value;
                }
                else if (value == 300)
                    rating = 299;
                else
                    rating = -1250;
            }
        }
    }
}
