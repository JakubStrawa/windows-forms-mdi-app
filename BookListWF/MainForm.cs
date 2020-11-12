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
        Document mainDocument = new Document();

        public MainForm()
        {
            InitializeComponent();
            IsMdiContainer = true;
        }
    }
}
