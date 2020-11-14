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
            IWindowsFormsEditorService edSvc = (IWindowsFormsEditorService)provider.GetService(typeof(IWindowsFormsEditorService));
            if (edSvc != null)
            {
                GenreControl genreControl = new GenreControl((Genres)value);
                edSvc.DropDownControl(genreControl);
                if (value.GetType() == typeof(Genres))
                    return genreControl.Genre;
                else if (value.GetType() == typeof(int))
                    return (int)genreControl.Genre;
            }
            return value;
        }

        public override void PaintValue(System.Drawing.Design.PaintValueEventArgs e)
        {
            Image image = null;
            switch ((int)e.Value)
            {
                case 1:
                    image = global::BookListWF.Properties.Resources.fantasy;
                    break;
                case 2:
                    image = global::BookListWF.Properties.Resources.detective;
                    break;
                default:
                    image = global::BookListWF.Properties.Resources.poetry;
                    break;
            }
            e.Graphics.DrawImage(image, 0, 0, e.Bounds.Width, e.Bounds.Height);
        }

        public override bool GetPaintValueSupported(System.ComponentModel.ITypeDescriptorContext context)
        {
            return true;
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
            { genre = value; ChangeImage(); }
        }

        private Genres genre;
        private Image Image;

        public event Action<Genres> ChangeGenreEvent;

        public GenreControl() : this(0)
        {
            //this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            //this.genre = Genres.DetectiveStory;
            //Genre = genre;
            //Image = null;
            //ChangeCurrentImage(false);
            //this.Refresh();
        }

        public GenreControl(Genres genre)
        {
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            this.genre = genre;
            //Genre = genre;
            Image = null;
            ChangeCurrentImage(false);
            //this.Invalidate();
        }

        public void ChangeImage()
        {
            ChangeCurrentImage(false);
            this.Refresh();
        }

        private void ChangeCurrentImage(bool shouldChangeGenre)
        {
            int num = (int)genre;
            //genre = Genre;
            if (shouldChangeGenre)
            {
                num = (++num) % 3;
                genre = (Genres)num;
                //Genre = this.genre;
            }
            switch (num)
            {
                case 1:
                    this.Image = global::BookListWF.Properties.Resources.fantasy;
                    break;
                case 2:
                    this.Image = global::BookListWF.Properties.Resources.detective;
                    break;
                case 0:
                    this.Image = global::BookListWF.Properties.Resources.poetry;
                    break;
            }
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            //ChangeCurrentImage(false);
            base.OnPaint(pe);
            
            pe.Graphics.DrawImage(Image, 0, 0, this.Width, this.Height);
        }

        protected override void OnClick(EventArgs e)
        {
            ChangeCurrentImage(true);
            ChangeGenreEvent?.Invoke(genre);
            this.Refresh();
        }
    }
}
