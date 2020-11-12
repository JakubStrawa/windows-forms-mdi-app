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
    public partial class BookForm : Form
    {
        private Book book;
        private List<Book> books;

        public string BookTitle
        {
            get { return titleTextBox.Text; }
        }

        public string BookAuthor
        {
            get { return authorTextBox.Text; }
        }

        public DateTime BookReleaseDate
        {
            get { return releaseDateTimePicker.Value; }
        }

        public Genres BookGenre
        {
            get { return (Genres)genreComboBox.SelectedIndex; }
        }

        public BookForm(Book book, List<Book> books)
        {
            InitializeComponent();
            this.book = book;
            this.books = books;
        }

        private void BookForm_Load(object sender, EventArgs e)
        {
            if (book != null)
            {
                titleTextBox.Text = book.Title;
                authorTextBox.Text = book.Author;
                releaseDateTimePicker.Value = book.ReleaseDate;
                genreComboBox.SelectedIndex = (int)book.Genre;
            }
            else
            {
                titleTextBox.Text = "Harry Potter";
                authorTextBox.Text = "J. K. Rowling";
                releaseDateTimePicker.Value = new DateTime(1997, 6, 26);
                genreComboBox.SelectedIndex = (int)Genres.Fantasy;
            }
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
                DialogResult = DialogResult.OK;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void titleTextBox_Validated(object sender, EventArgs e)
        {
            titleErrorProvider.SetError(titleTextBox, "");
        }

        private void titleTextBox_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                if (BookTitle.Length <= 2)
                    throw new Exception("Book title is too short.");
                foreach (Book b in books)
                    if (b.Title == BookTitle && !ReferenceEquals(b, books))
                        throw new Exception("Book already exists.");
            }
            catch (Exception exception)
            {
                e.Cancel = true;
                titleErrorProvider.SetError(titleTextBox, exception.Message);
            }
        }

        private void authorTextBox_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                if (BookAuthor.Length <= 2)
                    throw new Exception("Author's name is too short.");
            }
            catch (Exception exception)
            {
                e.Cancel = true;
                authorErrorProvider.SetError(authorTextBox, exception.Message);
            }
        }

        private void authorTextBox_Validated(object sender, EventArgs e)
        {
            authorErrorProvider.SetError(authorTextBox, "");
        }
    }
}
