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
    public partial class MainForm : Form
    {
        Document MainDocument = new Document();

        public MainForm()
        {
            InitializeComponent();
            IsMdiContainer = true;
        }

        private void newViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BookListForm bookListForm = new BookListForm(MainDocument);
            bookListForm.MdiParent = this;
            bookListForm.Show();
            LayoutMdi(MdiLayout.TileVertical);
        }

    }
}
