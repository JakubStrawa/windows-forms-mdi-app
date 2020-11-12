namespace BookListWF
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.windowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newViewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainToolStrip = new System.Windows.Forms.ToolStrip();
            this.newViewToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.mainStatusStrip = new System.Windows.Forms.StatusStrip();
            this.activeElementsToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.mainMenuStrip.SuspendLayout();
            this.mainToolStrip.SuspendLayout();
            this.mainStatusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenuStrip
            // 
            this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.windowToolStripMenuItem});
            this.mainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.mainMenuStrip.Name = "mainMenuStrip";
            this.mainMenuStrip.Size = new System.Drawing.Size(751, 24);
            this.mainMenuStrip.TabIndex = 1;
            this.mainMenuStrip.Text = "mainMenuStrip";
            // 
            // windowToolStripMenuItem
            // 
            this.windowToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newViewToolStripMenuItem});
            this.windowToolStripMenuItem.Name = "windowToolStripMenuItem";
            this.windowToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.windowToolStripMenuItem.Text = "&Window";
            // 
            // newViewToolStripMenuItem
            // 
            this.newViewToolStripMenuItem.Name = "newViewToolStripMenuItem";
            this.newViewToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.newViewToolStripMenuItem.Text = "New View";
            this.newViewToolStripMenuItem.Click += new System.EventHandler(this.newViewToolStripMenuItem_Click);
            // 
            // mainToolStrip
            // 
            this.mainToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newViewToolStripButton});
            this.mainToolStrip.Location = new System.Drawing.Point(0, 24);
            this.mainToolStrip.Name = "mainToolStrip";
            this.mainToolStrip.Size = new System.Drawing.Size(751, 25);
            this.mainToolStrip.TabIndex = 2;
            this.mainToolStrip.Text = "mainToolStrip";
            // 
            // newViewToolStripButton
            // 
            this.newViewToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("newViewToolStripButton.Image")));
            this.newViewToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newViewToolStripButton.Name = "newViewToolStripButton";
            this.newViewToolStripButton.Size = new System.Drawing.Size(79, 22);
            this.newViewToolStripButton.Text = "New View";
            this.newViewToolStripButton.Click += new System.EventHandler(this.newViewToolStripMenuItem_Click);
            // 
            // mainStatusStrip
            // 
            this.mainStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.activeElementsToolStripStatusLabel});
            this.mainStatusStrip.Location = new System.Drawing.Point(0, 482);
            this.mainStatusStrip.Name = "mainStatusStrip";
            this.mainStatusStrip.Size = new System.Drawing.Size(751, 22);
            this.mainStatusStrip.TabIndex = 4;
            this.mainStatusStrip.Text = "statusStrip1";
            // 
            // activeElementsToolStripStatusLabel
            // 
            this.activeElementsToolStripStatusLabel.MergeAction = System.Windows.Forms.MergeAction.Insert;
            this.activeElementsToolStripStatusLabel.Name = "activeElementsToolStripStatusLabel";
            this.activeElementsToolStripStatusLabel.Size = new System.Drawing.Size(97, 17);
            this.activeElementsToolStripStatusLabel.Text = "Active elements: ";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 504);
            this.Controls.Add(this.mainStatusStrip);
            this.Controls.Add(this.mainToolStrip);
            this.Controls.Add(this.mainMenuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mainMenuStrip;
            this.Name = "MainForm";
            this.Text = "Books";
            this.mainMenuStrip.ResumeLayout(false);
            this.mainMenuStrip.PerformLayout();
            this.mainToolStrip.ResumeLayout(false);
            this.mainToolStrip.PerformLayout();
            this.mainStatusStrip.ResumeLayout(false);
            this.mainStatusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStripMenuItem windowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newViewToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton newViewToolStripButton;
        public System.Windows.Forms.MenuStrip mainMenuStrip;
        public System.Windows.Forms.ToolStrip mainToolStrip;
        private System.Windows.Forms.StatusStrip mainStatusStrip;
        private System.Windows.Forms.ToolStripStatusLabel activeElementsToolStripStatusLabel;
    }
}

