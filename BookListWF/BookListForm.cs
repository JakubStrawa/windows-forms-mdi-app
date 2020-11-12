using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookListWF
{
    public partial class BookListForm : Form
    {
        private Document Document
        {
            get;
            set;
        }

        public BookListForm(Document document)
        {
            InitializeComponent();
            Document = document;
        }

        private void BookListForm_Load(object sender, EventArgs e)
        {
            UpdateItems();
            Document.AddBookEvent += Document_AddBookEvent;
        }

        private void Document_AddBookEvent(Book book)
        {
            ListViewItem item = new ListViewItem();
            item.Tag = book;
            UpdateItem(item);
            bookListView.Items.Add(item);
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BookForm bookForm = new BookForm(null, Document.books);
            if (bookForm.ShowDialog() == DialogResult.OK)
            {
                Book newBook = new Book(bookForm.BookTitle, bookForm.BookAuthor, bookForm.BookReleaseDate, bookForm.BookGenre);

                Document.AddBook(newBook);

                //ListViewItem item = new ListViewItem();
                //item.Tag = newStudent;
                //UpdateItem(item);
                //studentsListView.Items.Add(item);
            }
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (bookListView.SelectedItems.Count == 1)
            {
                Book book = (Book)bookListView.SelectedItems[0].Tag;
                BookForm bookForm = new BookForm(book, Document.books);
                if (bookForm.ShowDialog() == DialogResult.OK)
                {
                    book.Title = bookForm.BookTitle;
                    book.Author = bookForm.BookAuthor;
                    book.ReleaseDate = bookForm.BookReleaseDate;
                    book.Genre = bookForm.BookGenre;

                    Document.UpdateBook(book);

                    //UpdateItem(studentsListView.SelectedItems[0]);
                }
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void UpdateItem(ListViewItem item)
        {
            Book book = (Book)item.Tag;
            while (item.SubItems.Count < 4)
                item.SubItems.Add(new ListViewItem.ListViewSubItem());
            item.SubItems[0].Text = book.Title;
            item.SubItems[1].Text = book.Author;
            item.SubItems[2].Text = book.ReleaseDate.ToLongTimeString();
            item.SubItems[3].Text = book.Genre.ToString();
        }

        private void UpdateItems()
        {
            bookListView.Items.Clear();
            foreach (Book book in Document.books)
            {
                ListViewItem item = new ListViewItem();
                item.Tag = book;
                UpdateItem(item);
                bookListView.Items.Add(item);
            }
        }

        private void BookListForm_Activated(object sender, EventArgs e)
        {
            ToolStripManager.Merge(childToolStrip, ((MainForm)MdiParent).mainToolStrip);
        }

        private void BookListForm_Deactivate(object sender, EventArgs e)
        {
            ToolStripManager.RevertMerge(((MainForm)MdiParent).mainToolStrip, childToolStrip);
        }
    }
}
