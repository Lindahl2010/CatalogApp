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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.displayBtn = new System.Windows.Forms.Button();
            this.searchBtn = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.idHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.titleHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.genreHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.releaseHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ratingHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // searchLbl
            // 
            this.searchLbl.AutoSize = true;
            this.searchLbl.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.searchLbl.ForeColor = System.Drawing.SystemColors.Control;
            this.searchLbl.Location = new System.Drawing.Point(12, 35);
            this.searchLbl.Name = "searchLbl";
            this.searchLbl.Size = new System.Drawing.Size(146, 17);
            this.searchLbl.TabIndex = 10;
            this.searchLbl.Text = "Search Movie Catalog";
            // 
            // entryBtn
            // 
            this.entryBtn.Location = new System.Drawing.Point(483, 236);
            this.entryBtn.Name = "entryBtn";
            this.entryBtn.Size = new System.Drawing.Size(269, 76);
            this.entryBtn.TabIndex = 7;
            this.entryBtn.Text = "New Entry";
            this.entryBtn.UseVisualStyleBackColor = true;
            this.entryBtn.Click += new System.EventHandler(this.entryBtn_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.textBox1.ForeColor = System.Drawing.SystemColors.Control;
            this.textBox1.Location = new System.Drawing.Point(12, 32);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(289, 22);
            this.textBox1.TabIndex = 8;
            // 
            // displayBtn
            // 
            this.displayBtn.Location = new System.Drawing.Point(483, 154);
            this.displayBtn.Name = "displayBtn";
            this.displayBtn.Size = new System.Drawing.Size(269, 76);
            this.displayBtn.TabIndex = 6;
            this.displayBtn.Text = "Show Movies";
            this.displayBtn.UseVisualStyleBackColor = true;
            this.displayBtn.Click += new System.EventHandler(this.displayBtn_Click);
            // 
            // searchBtn
            // 
            this.searchBtn.Location = new System.Drawing.Point(307, 32);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(75, 23);
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
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 61);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(370, 377);
            this.listView1.TabIndex = 11;
            this.listView1.UseCompatibleStateImageBehavior = false;
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.searchLbl);
            this.Controls.Add(this.entryBtn);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.displayBtn);
            this.Controls.Add(this.searchBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label searchLbl;
        private System.Windows.Forms.Button entryBtn;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button displayBtn;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader idHeader;
        private System.Windows.Forms.ColumnHeader titleHeader;
        private System.Windows.Forms.ColumnHeader genreHeader;
        private System.Windows.Forms.ColumnHeader releaseHeader;
        private System.Windows.Forms.ColumnHeader ratingHeader;
    }
}

