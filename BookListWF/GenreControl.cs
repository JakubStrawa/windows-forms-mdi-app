using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Design;
using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace BookListWF
{
    public class GenreEditor : System.Drawing.Design.UITypeEditor
    {
        [System.Security.Permissions.PermissionSet(System.Security.Permissions.SecurityAction.Demand, Name = "FullTrust")]
        public GenreEditor()
        {
        }

        public override System.Drawing.Design.UITypeEditorEditStyle GetEditStyle(System.ComponentModel.ITypeDescriptorContext context)
        {
            return UITypeEditorEditStyle.DropDown;
        }

        public override object EditValue(System.ComponentModel.ITypeDescriptorContext context, System.IServiceProvider provider, object value)
        {
            return value;
        }
    }
    public class GenreControl : System.Windows.Forms.PictureBox
    {
        [BrowsableAttribute(true)]
        [EditorAttribute(typeof(GenreEditor), typeof(System.Drawing.Design.UITypeEditor))]
        public Genres Genre
        {
            get
            { return genre; }
            set
            { genre = value; Invalidate(); }
        }

        private Genres genre;
        private Image Image;

        public GenreControl()
        {
            this.genre = Genres.Fantasy;
            Image = null;
            ChangeCurrentImage(false);
        }

        public GenreControl(Genres genre)
        {
            this.genre = genre;
            Image = null;
            ChangeCurrentImage(false);
        }

        private void ChangeCurrentImage(bool shouldChangeGenre)
        {
            int num = (int)genre;
            if (shouldChangeGenre)
            {
                num = (++num) % 3;
                genre = (Genres)num;
            }
            switch (num)
            {
                case 1:
                    this.Image = global::BookListWF.Properties.Resources.fantasy;
                    break;
                case 2:
                    this.Image = global::BookListWF.Properties.Resources.detective;
                    break;
                default:
                    this.Image = global::BookListWF.Properties.Resources.poetry;
                    break;
            }
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);

            pe.Graphics.DrawImage(Image, 0, 0, this.Width, this.Height);
        }

        protected override void OnClick(EventArgs e)
        {
            //base.OnClick(e);
            ChangeCurrentImage(true);
            this.Refresh();
        }
    }
}
