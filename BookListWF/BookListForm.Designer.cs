namespace BookListWF
{
    partial class BookListForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookListForm));
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.bookListView = new System.Windows.Forms.ListView();
            this.titleColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.authorColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.releaseDateColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.genreColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.childMenuStrip = new System.Windows.Forms.MenuStrip();
            this.editMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.childToolStrip = new System.Windows.Forms.ToolStrip();
            this.addToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.editToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.deleteToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.childContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addContextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editContextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteContextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.releasedBefore2000ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.releasedAfter2000ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.childStatusStrip = new System.Windows.Forms.StatusStrip();
            this.countToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripContainer1.BottomToolStripPanel.SuspendLayout();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.childMenuStrip.SuspendLayout();
            this.childToolStrip.SuspendLayout();
            this.childContextMenuStrip.SuspendLayout();
            this.childStatusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.BottomToolStripPanel
            // 
            this.toolStripContainer1.BottomToolStripPanel.Controls.Add(this.childStatusStrip);
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Controls.Add(this.bookListView);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(540, 307);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(540, 378);
            this.toolStripContainer1.TabIndex = 0;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.childMenuStrip);
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.childToolStrip);
            // 
            // bookListView
            // 
            this.bookListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.titleColumnHeader,
            this.authorColumnHeader,
            this.releaseDateColumnHeader,
            this.genreColumnHeader});
            this.bookListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bookListView.FullRowSelect = true;
            this.bookListView.HideSelection = false;
            this.bookListView.Location = new System.Drawing.Point(0, 0);
            this.bookListView.Name = "bookListView";
            this.bookListView.Size = new System.Drawing.Size(540, 307);
            this.bookListView.TabIndex = 0;
            this.bookListView.UseCompatibleStateImageBehavior = false;
            this.bookListView.View = System.Windows.Forms.View.Details;
            // 
            // titleColumnHeader
            // 
            this.titleColumnHeader.Text = "Title";
            // 
            // authorColumnHeader
            // 
            this.authorColumnHeader.Text = "Author";
            this.authorColumnHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // releaseDateColumnHeader
            // 
            this.releaseDateColumnHeader.Text = "Release Date";
            this.releaseDateColumnHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // genreColumnHeader
            // 
            this.genreColumnHeader.Text = "Genre";
            this.genreColumnHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // childMenuStrip
            // 
            this.childMenuStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.childMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editMenuToolStripMenuItem,
            this.showToolStripMenuItem});
            this.childMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.childMenuStrip.Name = "childMenuStrip";
            this.childMenuStrip.Size = new System.Drawing.Size(540, 24);
            this.childMenuStrip.TabIndex = 0;
            this.childMenuStrip.Text = "childMenuStrip";
            // 
            // editMenuToolStripMenuItem
            // 
            this.editMenuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.editToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.editMenuToolStripMenuItem.Name = "editMenuToolStripMenuItem";
            this.editMenuToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editMenuToolStripMenuItem.Text = "&Edit";
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.addToolStripMenuItem.Text = "Add";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // childToolStrip
            // 
            this.childToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.childToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripButton,
            this.editToolStripButton,
            this.deleteToolStripButton});
            this.childToolStrip.Location = new System.Drawing.Point(3, 24);
            this.childToolStrip.Name = "childToolStrip";
            this.childToolStrip.Size = new System.Drawing.Size(199, 25);
            this.childToolStrip.TabIndex = 1;
            // 
            // addToolStripButton
            // 
            this.addToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("addToolStripButton.Image")));
            this.addToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.addToolStripButton.Name = "addToolStripButton";
            this.addToolStripButton.Size = new System.Drawing.Size(49, 22);
            this.addToolStripButton.Text = "Add";
            this.addToolStripButton.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
            // 
            // editToolStripButton
            // 
            this.editToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("editToolStripButton.Image")));
            this.editToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.editToolStripButton.Name = "editToolStripButton";
            this.editToolStripButton.Size = new System.Drawing.Size(47, 22);
            this.editToolStripButton.Text = "Edit";
            this.editToolStripButton.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // deleteToolStripButton
            // 
            this.deleteToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("deleteToolStripButton.Image")));
            this.deleteToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.deleteToolStripButton.Name = "deleteToolStripButton";
            this.deleteToolStripButton.Size = new System.Drawing.Size(60, 22);
            this.deleteToolStripButton.Text = "Delete";
            this.deleteToolStripButton.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // childContextMenuStrip
            // 
            this.childContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addContextToolStripMenuItem,
            this.editContextToolStripMenuItem,
            this.deleteContextToolStripMenuItem});
            this.childContextMenuStrip.Name = "childContextMenuStrip";
            this.childContextMenuStrip.Size = new System.Drawing.Size(108, 70);
            // 
            // addContextToolStripMenuItem
            // 
            this.addContextToolStripMenuItem.Name = "addContextToolStripMenuItem";
            this.addContextToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.addContextToolStripMenuItem.Text = "Add";
            this.addContextToolStripMenuItem.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
            // 
            // editContextToolStripMenuItem
            // 
            this.editContextToolStripMenuItem.Name = "editContextToolStripMenuItem";
            this.editContextToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.editContextToolStripMenuItem.Text = "Edit";
            this.editContextToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // deleteContextToolStripMenuItem
            // 
            this.deleteContextToolStripMenuItem.Name = "deleteContextToolStripMenuItem";
            this.deleteContextToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.deleteContextToolStripMenuItem.Text = "Delete";
            this.deleteContextToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // showToolStripMenuItem
            // 
            this.showToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.allToolStripMenuItem,
            this.releasedBefore2000ToolStripMenuItem,
            this.releasedAfter2000ToolStripMenuItem});
            this.showToolStripMenuItem.Name = "showToolStripMenuItem";
            this.showToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.showToolStripMenuItem.Text = "&Show";
            // 
            // allToolStripMenuItem
            // 
            this.allToolStripMenuItem.Checked = true;
            this.allToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.allToolStripMenuItem.Name = "allToolStripMenuItem";
            this.allToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.allToolStripMenuItem.Text = "All";
            this.allToolStripMenuItem.Click += new System.EventHandler(this.allToolStripMenuItem_Click);
            // 
            // releasedBefore2000ToolStripMenuItem
            // 
            this.releasedBefore2000ToolStripMenuItem.Name = "releasedBefore2000ToolStripMenuItem";
            this.releasedBefore2000ToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.releasedBefore2000ToolStripMenuItem.Text = "Released before 2000";
            this.releasedBefore2000ToolStripMenuItem.Click += new System.EventHandler(this.releasedBefore2000ToolStripMenuItem_Click);
            // 
            // releasedAfter2000ToolStripMenuItem
            // 
            this.releasedAfter2000ToolStripMenuItem.Name = "releasedAfter2000ToolStripMenuItem";
            this.releasedAfter2000ToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.releasedAfter2000ToolStripMenuItem.Text = "Released after 2000";
            this.releasedAfter2000ToolStripMenuItem.Click += new System.EventHandler(this.releasedAfter2000ToolStripMenuItem_Click);
            // 
            // childStatusStrip
            // 
            this.childStatusStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.childStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.countToolStripStatusLabel});
            this.childStatusStrip.Location = new System.Drawing.Point(0, 0);
            this.childStatusStrip.Name = "childStatusStrip";
            this.childStatusStrip.Size = new System.Drawing.Size(540, 22);
            this.childStatusStrip.TabIndex = 0;
            // 
            // countToolStripStatusLabel
            // 
            this.countToolStripStatusLabel.MergeAction = System.Windows.Forms.MergeAction.Insert;
            this.countToolStripStatusLabel.Name = "countToolStripStatusLabel";
            this.countToolStripStatusLabel.Size = new System.Drawing.Size(13, 17);
            this.countToolStripStatusLabel.Text = "0";
            // 
            // BookListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 378);
            this.ContextMenuStrip = this.childContextMenuStrip;
            this.Controls.Add(this.toolStripContainer1);
            this.MainMenuStrip = this.childMenuStrip;
            this.Name = "BookListForm";
            this.Text = "Book List";
            this.Activated += new System.EventHandler(this.BookListForm_Activated);
            this.Deactivate += new System.EventHandler(this.BookListForm_Deactivate);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BookListForm_FormClosing);
            this.Load += new System.EventHandler(this.BookListForm_Load);
            this.toolStripContainer1.BottomToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.BottomToolStripPanel.PerformLayout();
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.childMenuStrip.ResumeLayout(false);
            this.childMenuStrip.PerformLayout();
            this.childToolStrip.ResumeLayout(false);
            this.childToolStrip.PerformLayout();
            this.childContextMenuStrip.ResumeLayout(false);
            this.childStatusStrip.ResumeLayout(false);
            this.childStatusStrip.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.MenuStrip childMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem editMenuToolStripMenuItem;
        private System.Windows.Forms.ToolStrip childToolStrip;
        private System.Windows.Forms.ToolStripButton addToolStripButton;
        private System.Windows.Forms.ToolStripButton editToolStripButton;
        private System.Windows.Forms.ListView bookListView;
        private System.Windows.Forms.ColumnHeader titleColumnHeader;
        private System.Windows.Forms.ColumnHeader authorColumnHeader;
        private System.Windows.Forms.ColumnHeader releaseDateColumnHeader;
        private System.Windows.Forms.ColumnHeader genreColumnHeader;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton deleteToolStripButton;
        private System.Windows.Forms.ContextMenuStrip childContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem addContextToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editContextToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteContextToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem allToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem releasedBefore2000ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem releasedAfter2000ToolStripMenuItem;
        private System.Windows.Forms.StatusStrip childStatusStrip;
        private System.Windows.Forms.ToolStripStatusLabel countToolStripStatusLabel;
    }
}