namespace BookListWF
{
    partial class BookForm
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.OKButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.titleLabel = new System.Windows.Forms.Label();
            this.authorLabel = new System.Windows.Forms.Label();
            this.releaseDateLabel = new System.Windows.Forms.Label();
            this.genreLabel = new System.Windows.Forms.Label();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.authorTextBox = new System.Windows.Forms.TextBox();
            this.releaseDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.genreComboBox = new System.Windows.Forms.ComboBox();
            this.titleErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.authorErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.genreControl1 = new BookListWF.GenreControl();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.titleErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.authorErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.genreControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(425, 380);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 5;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.Controls.Add(this.OKButton, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.cancelButton, 3, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 288);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(419, 89);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // OKButton
            // 
            this.OKButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OKButton.Location = new System.Drawing.Point(86, 27);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(77, 34);
            this.OKButton.TabIndex = 0;
            this.OKButton.Text = "OK";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cancelButton.Location = new System.Drawing.Point(252, 27);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(77, 34);
            this.cancelButton.TabIndex = 1;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 4;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel3.Controls.Add(this.titleLabel, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.authorLabel, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.releaseDateLabel, 1, 3);
            this.tableLayoutPanel3.Controls.Add(this.genreLabel, 1, 4);
            this.tableLayoutPanel3.Controls.Add(this.titleTextBox, 2, 1);
            this.tableLayoutPanel3.Controls.Add(this.authorTextBox, 2, 2);
            this.tableLayoutPanel3.Controls.Add(this.releaseDateTimePicker, 2, 3);
            this.tableLayoutPanel3.Controls.Add(this.genreComboBox, 2, 4);
            this.tableLayoutPanel3.Controls.Add(this.genreControl1, 2, 5);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 6;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(419, 279);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // titleLabel
            // 
            this.titleLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.titleLabel.AutoSize = true;
            this.titleLabel.Location = new System.Drawing.Point(23, 45);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(77, 13);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Title";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // authorLabel
            // 
            this.authorLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.authorLabel.AutoSize = true;
            this.authorLabel.Location = new System.Drawing.Point(23, 95);
            this.authorLabel.Name = "authorLabel";
            this.authorLabel.Size = new System.Drawing.Size(77, 13);
            this.authorLabel.TabIndex = 1;
            this.authorLabel.Text = "Author";
            this.authorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // releaseDateLabel
            // 
            this.releaseDateLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.releaseDateLabel.AutoSize = true;
            this.releaseDateLabel.Location = new System.Drawing.Point(23, 145);
            this.releaseDateLabel.Name = "releaseDateLabel";
            this.releaseDateLabel.Size = new System.Drawing.Size(77, 13);
            this.releaseDateLabel.TabIndex = 2;
            this.releaseDateLabel.Text = "Release Date";
            this.releaseDateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // genreLabel
            // 
            this.genreLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.genreLabel.AutoSize = true;
            this.genreLabel.Location = new System.Drawing.Point(23, 195);
            this.genreLabel.Name = "genreLabel";
            this.genreLabel.Size = new System.Drawing.Size(77, 13);
            this.genreLabel.TabIndex = 3;
            this.genreLabel.Text = "Genre";
            this.genreLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // titleTextBox
            // 
            this.titleTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.titleTextBox.Location = new System.Drawing.Point(106, 42);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(266, 20);
            this.titleTextBox.TabIndex = 4;
            this.titleTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.titleTextBox_Validating);
            this.titleTextBox.Validated += new System.EventHandler(this.titleTextBox_Validated);
            // 
            // authorTextBox
            // 
            this.authorTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.authorTextBox.Location = new System.Drawing.Point(106, 92);
            this.authorTextBox.Name = "authorTextBox";
            this.authorTextBox.Size = new System.Drawing.Size(266, 20);
            this.authorTextBox.TabIndex = 5;
            this.authorTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.authorTextBox_Validating);
            this.authorTextBox.Validated += new System.EventHandler(this.authorTextBox_Validated);
            // 
            // releaseDateTimePicker
            // 
            this.releaseDateTimePicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.releaseDateTimePicker.Location = new System.Drawing.Point(106, 142);
            this.releaseDateTimePicker.Name = "releaseDateTimePicker";
            this.releaseDateTimePicker.Size = new System.Drawing.Size(266, 20);
            this.releaseDateTimePicker.TabIndex = 6;
            // 
            // genreComboBox
            // 
            this.genreComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.genreComboBox.FormattingEnabled = true;
            this.genreComboBox.Items.AddRange(new object[] {
            "Poetry",
            "Fantasy",
            "Detective Story"});
            this.genreComboBox.Location = new System.Drawing.Point(106, 191);
            this.genreComboBox.Name = "genreComboBox";
            this.genreComboBox.Size = new System.Drawing.Size(266, 21);
            this.genreComboBox.TabIndex = 7;
            // 
            // titleErrorProvider
            // 
            this.titleErrorProvider.ContainerControl = this;
            // 
            // authorErrorProvider
            // 
            this.authorErrorProvider.ContainerControl = this;
            // 
            // genreControl1
            // 
            this.genreControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.genreControl1.Genre = BookListWF.Genres.Poetry;
            this.genreControl1.Location = new System.Drawing.Point(106, 230);
            this.genreControl1.Name = "genreControl1";
            this.genreControl1.Size = new System.Drawing.Size(266, 46);
            this.genreControl1.TabIndex = 8;
            this.genreControl1.TabStop = false;
            // 
            // BookForm
            // 
            this.AcceptButton = this.OKButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(425, 380);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "BookForm";
            this.Text = "Book";
            this.Load += new System.EventHandler(this.BookForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.titleErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.authorErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.genreControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button OKButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label authorLabel;
        private System.Windows.Forms.Label releaseDateLabel;
        private System.Windows.Forms.Label genreLabel;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.TextBox authorTextBox;
        private System.Windows.Forms.DateTimePicker releaseDateTimePicker;
        private System.Windows.Forms.ComboBox genreComboBox;
        private System.Windows.Forms.ErrorProvider titleErrorProvider;
        private System.Windows.Forms.ErrorProvider authorErrorProvider;
        private GenreControl genreControl1;
    }
}