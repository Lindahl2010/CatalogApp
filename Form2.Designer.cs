namespace CatalogApp
{
    partial class NewEntry
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
            this.titleTxtBox = new System.Windows.Forms.TextBox();
            this.genreTxtBox = new System.Windows.Forms.TextBox();
            this.titleLbl = new System.Windows.Forms.Label();
            this.genreLbl = new System.Windows.Forms.Label();
            this.yearLbl = new System.Windows.Forms.Label();
            this.releaseCmbBox = new System.Windows.Forms.ComboBox();
            this.rateCmbBox = new System.Windows.Forms.ComboBox();
            this.addBtn = new System.Windows.Forms.Button();
            this.rateLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // titleTxtBox
            // 
            this.titleTxtBox.Location = new System.Drawing.Point(148, 148);
            this.titleTxtBox.MaxLength = 255;
            this.titleTxtBox.Name = "titleTxtBox";
            this.titleTxtBox.Size = new System.Drawing.Size(195, 22);
            this.titleTxtBox.TabIndex = 0;
            // 
            // genreTxtBox
            // 
            this.genreTxtBox.Location = new System.Drawing.Point(148, 176);
            this.genreTxtBox.MaxLength = 255;
            this.genreTxtBox.Name = "genreTxtBox";
            this.genreTxtBox.Size = new System.Drawing.Size(195, 22);
            this.genreTxtBox.TabIndex = 1;
            // 
            // titleLbl
            // 
            this.titleLbl.AutoSize = true;
            this.titleLbl.Location = new System.Drawing.Point(62, 151);
            this.titleLbl.Name = "titleLbl";
            this.titleLbl.Size = new System.Drawing.Size(80, 17);
            this.titleLbl.TabIndex = 2;
            this.titleLbl.Text = "Movie Title:";
            // 
            // genreLbl
            // 
            this.genreLbl.AutoSize = true;
            this.genreLbl.Location = new System.Drawing.Point(90, 179);
            this.genreLbl.Name = "genreLbl";
            this.genreLbl.Size = new System.Drawing.Size(52, 17);
            this.genreLbl.TabIndex = 3;
            this.genreLbl.Text = "Genre:";
            // 
            // yearLbl
            // 
            this.yearLbl.AutoSize = true;
            this.yearLbl.Location = new System.Drawing.Point(44, 207);
            this.yearLbl.Name = "yearLbl";
            this.yearLbl.Size = new System.Drawing.Size(98, 17);
            this.yearLbl.TabIndex = 4;
            this.yearLbl.Text = "Release Date:";
            // 
            // releaseCmbBox
            // 
            this.releaseCmbBox.DropDownHeight = 80;
            this.releaseCmbBox.FormattingEnabled = true;
            this.releaseCmbBox.IntegralHeight = false;
            this.releaseCmbBox.Location = new System.Drawing.Point(148, 204);
            this.releaseCmbBox.MaxDropDownItems = 4;
            this.releaseCmbBox.MaxLength = 4;
            this.releaseCmbBox.Name = "releaseCmbBox";
            this.releaseCmbBox.Size = new System.Drawing.Size(121, 24);
            this.releaseCmbBox.TabIndex = 5;
            // 
            // rateCmbBox
            // 
            this.rateCmbBox.DropDownHeight = 80;
            this.rateCmbBox.FormattingEnabled = true;
            this.rateCmbBox.IntegralHeight = false;
            this.rateCmbBox.Location = new System.Drawing.Point(148, 234);
            this.rateCmbBox.Name = "rateCmbBox";
            this.rateCmbBox.Size = new System.Drawing.Size(121, 24);
            this.rateCmbBox.TabIndex = 6;
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(148, 264);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(121, 23);
            this.addBtn.TabIndex = 7;
            this.addBtn.Text = "Add Movie";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // rateLbl
            // 
            this.rateLbl.AutoSize = true;
            this.rateLbl.Location = new System.Drawing.Point(89, 237);
            this.rateLbl.Name = "rateLbl";
            this.rateLbl.Size = new System.Drawing.Size(53, 17);
            this.rateLbl.TabIndex = 8;
            this.rateLbl.Text = "Rating:";
            // 
            // NewEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 433);
            this.Controls.Add(this.rateLbl);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.rateCmbBox);
            this.Controls.Add(this.releaseCmbBox);
            this.Controls.Add(this.yearLbl);
            this.Controls.Add(this.genreLbl);
            this.Controls.Add(this.titleLbl);
            this.Controls.Add(this.genreTxtBox);
            this.Controls.Add(this.titleTxtBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NewEntry";
            this.Text = "New Entry";
            this.Load += new System.EventHandler(this.NewEntry_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox titleTxtBox;
        private System.Windows.Forms.TextBox genreTxtBox;
        private System.Windows.Forms.Label titleLbl;
        private System.Windows.Forms.Label genreLbl;
        private System.Windows.Forms.Label yearLbl;
        private System.Windows.Forms.ComboBox releaseCmbBox;
        private System.Windows.Forms.ComboBox rateCmbBox;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Label rateLbl;
    }
}