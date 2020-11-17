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
            bookListView.Items.Clear();
            UpdateItems();
            Document.AddBookEvent += Document_AddBookEvent;
            Document.UpdateBookEvent += Document_UpdateBookEvent;
            Document.DeleteBookEvent += Document_DeleteBookEvent;
        }

        private void Document_AddBookEvent(Book book)
        {
            if (shouldShowBook(book))
            {
                ListViewItem item = new ListViewItem();
                item.Tag = book;
                UpdateItem(item);
                bookListView.Items.Add(item);
                countToolStripStatusLabel.Text = bookListView.Items.Count.ToString();
            }
        }

        private void Document_UpdateBookEvent(Book book)
        {
            if (shouldShowBook(book))
            {
                foreach (ListViewItem i in bookListView.Items)
                {
                    if (ReferenceEquals(i.Tag, book))
                    {
                        i.Tag = book;
                        UpdateItem(i);
                        return;
                    }
                }
                ListViewItem item = new ListViewItem();
                item.Tag = book;
                UpdateItem(item);
                bookListView.Items.Add(item);
            }
            else
            {
                foreach (ListViewItem i in bookListView.Items)
                    if (ReferenceEquals(i.Tag, book))
                    {
                        bookListView.Items.Remove(i);
                        break;
                    }
            }
            countToolStripStatusLabel.Text = bookListView.Items.Count.ToString();
        }

        private void Document_DeleteBookEvent(Book book)
        {
            if (shouldShowBook(book))
            {
                foreach (ListViewItem i in bookListView.Items)
                {
                    if (ReferenceEquals(i.Tag, book))
                    {
                        bookListView.Items.Remove(i);
                    }
                }
                countToolStripStatusLabel.Text = bookListView.Items.Count.ToString();
            }
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BookForm bookForm = new BookForm(null, Document.books);
            if (bookForm.ShowDialog() == DialogResult.OK)
            {
                Book newBook = new Book(bookForm.BookTitle, bookForm.BookAuthor, bookForm.BookReleaseDate, bookForm.BookGenre);
                Document.AddBook(newBook);
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
                }
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (bookListView.SelectedItems.Count == 1)
            {
                Book book = (Book)bookListView.SelectedItems[0].Tag;
                Document.DeleteBook(book);
            }
        }

        private void UpdateItem(ListViewItem item)
        {
            //function called when new item needs to be updated
            Book book = (Book)item.Tag;
            while (item.SubItems.Count < 4)
                item.SubItems.Add(new ListViewItem.ListViewSubItem());
            item.SubItems[0].Text = book.Title;
            item.SubItems[1].Text = book.Author;
            item.SubItems[2].Text = book.ReleaseDate.ToShortDateString();
            item.SubItems[3].Text = book.Genre.ToString();
        }

        private void UpdateItems()
        {
            //only called when new Form is created
            //function creates new listView content from current version of main document
            foreach (Book book in Document.books)
                if (shouldShowBook(book) == true)
                {
                    ListViewItem item = new ListViewItem();
                    item.Tag = book;
                    UpdateItem(item);
                    bookListView.Items.Add(item);
                }
            countToolStripStatusLabel.Text = bookListView.Items.Count.ToString();
        }

        private void BookListForm_Activated(object sender, EventArgs e)
        {
            ToolStripManager.Merge(childToolStrip, ((MainForm)MdiParent).mainToolStrip);
            ToolStripManager.Merge(childStatusStrip, ((MainForm)MdiParent).mainStatusStrip);
        }

        private void BookListForm_Deactivate(object sender, EventArgs e)
        {
            ToolStripManager.RevertMerge(((MainForm)MdiParent).mainToolStrip, this.childToolStrip);
            ToolStripManager.RevertMerge(((MainForm)MdiParent).mainStatusStrip, this.childStatusStrip);
        }

        private void BookListForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if ( MdiParent.MdiChildren.Length == 1 && e.CloseReason != CloseReason.MdiFormClosing)
            {
                e.Cancel = true;
            }
        }

        private void releasedBefore2000_Click(object sender, EventArgs e)
        {
            if (releasedAfter2000ToolStripMenuItem.Checked)
            {
                bookListView.Items.Clear();
                updateCheckedItem(1);
                UpdateItems();
            }
            else
            {
                updateCheckedItem(1);
                foreach (ListViewItem i in bookListView.Items)
                {
                    Book book = (Book)i.Tag;
                    if (!shouldShowBook(book))
                    {
                        bookListView.Items.Remove(i);
                    }
                }
                countToolStripStatusLabel.Text = bookListView.Items.Count.ToString();
            }
        }

        private void releasedAfter2000_Click(object sender, EventArgs e)
        {
            if (releasedBefore2000ToolStripMenuItem.Checked)
            {
                bookListView.Items.Clear();
                updateCheckedItem(2);
                UpdateItems();
            }
            else
            {
                updateCheckedItem(2);
                foreach (ListViewItem i in bookListView.Items)
                {
                    Book book = (Book)i.Tag;
                    if (!shouldShowBook(book))
                    {
                        bookListView.Items.Remove(i);
                    }
                }
                countToolStripStatusLabel.Text = bookListView.Items.Count.ToString();
            }
            
        }

        private void showAll_Click(object sender, EventArgs e)
        {
            DateTime date2000 = new DateTime(2000, 1, 1);
            
            foreach (Book book in Document.books)
            {
                if (releasedBefore2000ToolStripMenuItem.Checked && DateTime.Compare(book.ReleaseDate, date2000) >= 0)
                {
                    ListViewItem item = new ListViewItem();
                    item.Tag = book;
                    UpdateItem(item);
                    bookListView.Items.Add(item);
                }
                else if (releasedAfter2000ToolStripMenuItem.Checked && DateTime.Compare(book.ReleaseDate, date2000) < 0)
                {
                    ListViewItem item = new ListViewItem();
                    item.Tag = book;
                    UpdateItem(item);
                    bookListView.Items.Add(item);
                }
            }
            updateCheckedItem(0);
            countToolStripStatusLabel.Text = bookListView.Items.Count.ToString();
        }

        private bool shouldShowBook(Book book)
        {
            DateTime date2000 = new DateTime(2000, 1, 1);

            if (releasedBefore2000ToolStripMenuItem.Checked)
            {
                return DateTime.Compare(book.ReleaseDate, date2000) < 0;
            }
            else if (releasedAfter2000ToolStripMenuItem.Checked)
            {
                return DateTime.Compare(book.ReleaseDate, date2000) >= 0;
            }
            else
            {
                return true;
            }
        }

        private void updateCheckedItem(int num)
        {
            if (num >= 0 && num < 3)
            {
                releasedBefore2000ToolStripMenuItem.Checked = false;
                allToolStripMenuItem.Checked = false;
                releasedAfter2000ToolStripMenuItem.Checked = false;
                switch (num)
                {
                    case 0:
                        allToolStripMenuItem.Checked = true;
                        break;
                    case 1:
                        releasedBefore2000ToolStripMenuItem.Checked = true;
                        break;
                    case 2:
                        releasedAfter2000ToolStripMenuItem.Checked = true;
                        break;
                }
            }
        }
    }
}
