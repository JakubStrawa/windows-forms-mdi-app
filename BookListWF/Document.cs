using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookListWF
{
    public class Document
    {
        public List<Book> books = new List<Book>();

        public event Action<Book> AddBookEvent;
        public event Action<Book> UpdateBookEvent;
        public event Action<Book> DeleteBookEvent;

        public void AddBook(Book book)
        {
            books.Add(book);

            AddBookEvent?.Invoke(book);
        }

        public void UpdateBook(Book book)
        {
            //throw new NotImplementedException();
            foreach (Book b in books)
                if(ReferenceEquals(b, book))
                {
                    b.Title = book.Title;
                    b.Author = book.Author;
                    b.ReleaseDate = book.ReleaseDate;
                    b.Genre = book.Genre;
                }
            UpdateBookEvent?.Invoke(book);
        }

        public void DeleteBook(Book book)
        {
            books.Remove(book);
            DeleteBookEvent?.Invoke(book);
        }
    }
}
