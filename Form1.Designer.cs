namespace CatalogApp
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
            this.searchLbl = new System.Windows.Forms.Label();
            this.entryBtn = new System.Windows.Forms.Button();
            this.searchTxtBox = new System.Windows.Forms.TextBox();
            this.displayBtn = new System.Windows.Forms.Button();
            this.searchBtn = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.idHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.titleHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.genreHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.releaseHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ratingHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.genreRdBtn = new System.Windows.Forms.RadioButton();
            this.titleRdBtn = new System.Windows.Forms.RadioButton();
            this.filterLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // searchLbl
            // 
            this.searchLbl.AutoSize = true;
            this.searchLbl.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.searchLbl.ForeColor = System.Drawing.SystemColors.Control;
            this.searchLbl.Location = new System.Drawing.Point(21, 35);
            this.searchLbl.Name = "searchLbl";
            this.searchLbl.Size = new System.Drawing.Size(146, 17);
            this.searchLbl.TabIndex = 10;
            this.searchLbl.Text = "Search Movie Catalog";
            // 
            // entryBtn
            // 
            this.entryBtn.Location = new System.Drawing.Point(483, 236);
            this.entryBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.entryBtn.Name = "entryBtn";
            this.entryBtn.Size = new System.Drawing.Size(269, 76);
            this.entryBtn.TabIndex = 7;
            this.entryBtn.Text = "New Entry";
            this.entryBtn.UseVisualStyleBackColor = true;
            this.entryBtn.Click += new System.EventHandler(this.entryBtn_Click);
            // 
            // searchTxtBox
            // 
            this.searchTxtBox.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.searchTxtBox.ForeColor = System.Drawing.SystemColors.Control;
            this.searchTxtBox.Location = new System.Drawing.Point(12, 32);
            this.searchTxtBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.searchTxtBox.Name = "searchTxtBox";
            this.searchTxtBox.Size = new System.Drawing.Size(289, 22);
            this.searchTxtBox.TabIndex = 8;
            this.searchTxtBox.TextChanged += new System.EventHandler(this.searchTxtBox_TextChanged);
            // 
            // displayBtn
            // 
            this.displayBtn.Location = new System.Drawing.Point(483, 154);
            this.displayBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.displayBtn.Name = "displayBtn";
            this.displayBtn.Size = new System.Drawing.Size(269, 76);
            this.displayBtn.TabIndex = 6;
            this.displayBtn.Text = "Show All Movies";
            this.displayBtn.UseVisualStyleBackColor = true;
            this.displayBtn.Click += new System.EventHandler(this.displayBtn_Click);
            // 
            // searchBtn
            // 
            this.searchBtn.Location = new System.Drawing.Point(307, 32);
            this.searchBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(75, 23);
            this.searchBtn.TabIndex = 9;
            this.searchBtn.Text = "Search";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.idHeader,
            this.titleHeader,
            this.genreHeader,
            this.releaseHeader,
            this.ratingHeader});
            this.listView1.FullRowSelect = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 62);
            this.listView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(404, 377);
            this.listView1.TabIndex = 11;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.DoubleClick += new System.EventHandler(this.listView1_DoubleClick);
            // 
            // idHeader
            // 
            this.idHeader.Text = "Movie ID";
            this.idHeader.Width = 69;
            // 
            // titleHeader
            // 
            this.titleHeader.Text = "Title";
            // 
            // genreHeader
            // 
            this.genreHeader.Text = "Genre";
            // 
            // releaseHeader
            // 
            this.releaseHeader.Text = "Release Year";
            // 
            // ratingHeader
            // 
            this.ratingHeader.Text = "Rating";
            // 
            // genreRdBtn
            // 
            this.genreRdBtn.AutoSize = true;
            this.genreRdBtn.Location = new System.Drawing.Point(389, 34);
            this.genreRdBtn.Margin = new System.Windows.Forms.Padding(4);
            this.genreRdBtn.Name = "genreRdBtn";
            this.genreRdBtn.Size = new System.Drawing.Size(69, 21);
            this.genreRdBtn.TabIndex = 12;
            this.genreRdBtn.Text = "Genre";
            this.genreRdBtn.UseVisualStyleBackColor = true;
            // 
            // titleRdBtn
            // 
            this.titleRdBtn.AutoSize = true;
            this.titleRdBtn.Checked = true;
            this.titleRdBtn.Location = new System.Drawing.Point(469, 34);
            this.titleRdBtn.Margin = new System.Windows.Forms.Padding(4);
            this.titleRdBtn.Name = "titleRdBtn";
            this.titleRdBtn.Size = new System.Drawing.Size(56, 21);
            this.titleRdBtn.TabIndex = 13;
            this.titleRdBtn.TabStop = true;
            this.titleRdBtn.Text = "Title";
            this.titleRdBtn.UseVisualStyleBackColor = true;
            // 
            // filterLbl
            // 
            this.filterLbl.AutoSize = true;
            this.filterLbl.Location = new System.Drawing.Point(389, 11);
            this.filterLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.filterLbl.Name = "filterLbl";
            this.filterLbl.Size = new System.Drawing.Size(63, 17);
            this.filterLbl.TabIndex = 14;
            this.filterLbl.Text = "Filter By:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 453);
            this.Controls.Add(this.filterLbl);
            this.Controls.Add(this.titleRdBtn);
            this.Controls.Add(this.genreRdBtn);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.searchLbl);
            this.Controls.Add(this.entryBtn);
            this.Controls.Add(this.searchTxtBox);
            this.Controls.Add(this.displayBtn);
            this.Controls.Add(this.searchBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainForm";
            this.Text = "Movie Catalog";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label searchLbl;
        private System.Windows.Forms.Button entryBtn;
        private System.Windows.Forms.TextBox searchTxtBox;
        private System.Windows.Forms.Button displayBtn;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader idHeader;
        private System.Windows.Forms.ColumnHeader titleHeader;
        private System.Windows.Forms.ColumnHeader genreHeader;
        private System.Windows.Forms.ColumnHeader releaseHeader;
        private System.Windows.Forms.ColumnHeader ratingHeader;
        private System.Windows.Forms.RadioButton genreRdBtn;
        private System.Windows.Forms.RadioButton titleRdBtn;
        private System.Windows.Forms.Label filterLbl;
    }
}

