namespace CatalogApp
{
    partial class Form1
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
            this.searchLbl.Location = new System.Drawing.Point(9, 28);
            this.searchLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.searchLbl.Name = "searchLbl";
            this.searchLbl.Size = new System.Drawing.Size(112, 13);
            this.searchLbl.TabIndex = 10;
            this.searchLbl.Text = "Search Movie Catalog";
            // 
            // entryBtn
            // 
            this.entryBtn.Location = new System.Drawing.Point(362, 192);
            this.entryBtn.Margin = new System.Windows.Forms.Padding(2);
            this.entryBtn.Name = "entryBtn";
            this.entryBtn.Size = new System.Drawing.Size(202, 62);
            this.entryBtn.TabIndex = 7;
            this.entryBtn.Text = "New Entry";
            this.entryBtn.UseVisualStyleBackColor = true;
            this.entryBtn.Click += new System.EventHandler(this.entryBtn_Click);
            // 
            // searchTxtBox
            // 
            this.searchTxtBox.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.searchTxtBox.ForeColor = System.Drawing.SystemColors.Control;
            this.searchTxtBox.Location = new System.Drawing.Point(9, 26);
            this.searchTxtBox.Margin = new System.Windows.Forms.Padding(2);
            this.searchTxtBox.Name = "searchTxtBox";
            this.searchTxtBox.Size = new System.Drawing.Size(218, 20);
            this.searchTxtBox.TabIndex = 8;
            this.searchTxtBox.TextChanged += new System.EventHandler(this.searchTxtBox_TextChanged);
            // 
            // displayBtn
            // 
            this.displayBtn.Location = new System.Drawing.Point(362, 125);
            this.displayBtn.Margin = new System.Windows.Forms.Padding(2);
            this.displayBtn.Name = "displayBtn";
            this.displayBtn.Size = new System.Drawing.Size(202, 62);
            this.displayBtn.TabIndex = 6;
            this.displayBtn.Text = "Show Movies";
            this.displayBtn.UseVisualStyleBackColor = true;
            this.displayBtn.Click += new System.EventHandler(this.displayBtn_Click);
            // 
            // searchBtn
            // 
            this.searchBtn.Location = new System.Drawing.Point(230, 26);
            this.searchBtn.Margin = new System.Windows.Forms.Padding(2);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(56, 19);
            this.searchBtn.TabIndex = 9;
            this.searchBtn.Text = "Search";
            this.searchBtn.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.idHeader,
            this.titleHeader,
            this.genreHeader,
            this.releaseHeader,
            this.ratingHeader});
            this.listView1.Location = new System.Drawing.Point(9, 50);
            this.listView1.Margin = new System.Windows.Forms.Padding(2);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(304, 307);
            this.listView1.TabIndex = 11;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // idHeader
            // 
            this.idHeader.Text = "Movie ID";
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
            this.genreRdBtn.Location = new System.Drawing.Point(292, 28);
            this.genreRdBtn.Name = "genreRdBtn";
            this.genreRdBtn.Size = new System.Drawing.Size(54, 17);
            this.genreRdBtn.TabIndex = 12;
            this.genreRdBtn.TabStop = true;
            this.genreRdBtn.Text = "Genre";
            this.genreRdBtn.UseVisualStyleBackColor = true;
            // 
            // titleRdBtn
            // 
            this.titleRdBtn.AutoSize = true;
            this.titleRdBtn.Location = new System.Drawing.Point(352, 28);
            this.titleRdBtn.Name = "titleRdBtn";
            this.titleRdBtn.Size = new System.Drawing.Size(45, 17);
            this.titleRdBtn.TabIndex = 13;
            this.titleRdBtn.TabStop = true;
            this.titleRdBtn.Text = "Title";
            this.titleRdBtn.UseVisualStyleBackColor = true;
            // 
            // filterLbl
            // 
            this.filterLbl.AutoSize = true;
            this.filterLbl.Location = new System.Drawing.Point(292, 9);
            this.filterLbl.Name = "filterLbl";
            this.filterLbl.Size = new System.Drawing.Size(47, 13);
            this.filterLbl.TabIndex = 14;
            this.filterLbl.Text = "Filter By:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.filterLbl);
            this.Controls.Add(this.titleRdBtn);
            this.Controls.Add(this.genreRdBtn);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.searchLbl);
            this.Controls.Add(this.entryBtn);
            this.Controls.Add(this.searchTxtBox);
            this.Controls.Add(this.displayBtn);
            this.Controls.Add(this.searchBtn);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
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

