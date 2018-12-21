using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApp
{
    class Movie
    {
        public string Title { get; set; }
        public string Category { get; set; }

        public Movie(){}

        public Movie(string title, String category)
        {
            Title = title;
            Category = category;
        }
    }
}
