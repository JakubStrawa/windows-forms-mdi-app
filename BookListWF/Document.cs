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

        public void AddBook(Book book)
        {
            books.Add(book);

            AddBookEvent?.Invoke(book);
        }

        public void UpdateBook(Book book)
        {
            //throw new NotImplementedException();
        }
    }
}
