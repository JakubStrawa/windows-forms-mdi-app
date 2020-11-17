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
            BookListForm bookListForm = new BookListForm(MainDocument);
            bookListForm.MdiParent = this;
            bookListForm.Show();
            ChangeLayout();
        }

        private void newViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BookListForm bookListForm = new BookListForm(MainDocument);
            bookListForm.MdiParent = this;
            bookListForm.Show();
            ChangeLayout();
        }

        private void MainForm_ResizeEnd(object sender, EventArgs e)
        {
            ChangeLayout();
        }

        private void ChangeLayout()
        {
            if (verticalToolStripMenuItem.Checked)
                LayoutMdi(MdiLayout.TileVertical);
            else
                LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void horizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (verticalToolStripMenuItem.Checked)
            {
                horizontalToolStripMenuItem.Checked = true;
                verticalToolStripMenuItem.Checked = false;
                ChangeLayout();
            }
        }

        private void verticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (horizontalToolStripMenuItem.Checked)
            {
                horizontalToolStripMenuItem.Checked = false;
                verticalToolStripMenuItem.Checked = true;
                ChangeLayout();
            }
        }
    }
}
