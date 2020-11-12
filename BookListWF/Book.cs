using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookListWF
{
    public enum Genres
    {
        Poetry, Fantasy, DetectiveStory
    }

    public class Book
    {
        public string Title
        {
            get;
            set;
        }

        public string Author
        {
            get;
            set;
        }

        public DateTime ReleaseDate
        {
            get;
            set;
        }

        public Genres Genre
        {
            get;
            set;
        }

        public Book( string title, string author, DateTime releaseDate, Genres genre )
        {
            Title = title;
            Author = author;
            ReleaseDate = releaseDate;
            Genre = genre;
        }
    }
}
