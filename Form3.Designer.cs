namespace CatalogApp
{
    partial class ModifyEntry
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
            this.rateLbl = new System.Windows.Forms.Label();
            this.modifyBtn = new System.Windows.Forms.Button();
            this.rateCmbBox = new System.Windows.Forms.ComboBox();
            this.releaseCmbBox = new System.Windows.Forms.ComboBox();
            this.yearLbl = new System.Windows.Forms.Label();
            this.genreLbl = new System.Windows.Forms.Label();
            this.titleLbl = new System.Windows.Forms.Label();
            this.genreTxtBox = new System.Windows.Forms.TextBox();
            this.titleTxtBox = new System.Windows.Forms.TextBox();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rateLbl
            // 
            this.rateLbl.AutoSize = true;
            this.rateLbl.Location = new System.Drawing.Point(83, 234);
            this.rateLbl.Name = "rateLbl";
            this.rateLbl.Size = new System.Drawing.Size(53, 17);
            this.rateLbl.TabIndex = 17;
            this.rateLbl.Text = "Rating:";
            // 
            // modifyBtn
            // 
            this.modifyBtn.Location = new System.Drawing.Point(70, 261);
            this.modifyBtn.Name = "modifyBtn";
            this.modifyBtn.Size = new System.Drawing.Size(121, 23);
            this.modifyBtn.TabIndex = 16;
            this.modifyBtn.Text = "Modify Movie";
            this.modifyBtn.UseVisualStyleBackColor = true;
            // 
            // rateCmbBox
            // 
            this.rateCmbBox.DropDownHeight = 80;
            this.rateCmbBox.FormattingEnabled = true;
            this.rateCmbBox.IntegralHeight = false;
            this.rateCmbBox.Location = new System.Drawing.Point(142, 231);
            this.rateCmbBox.Name = "rateCmbBox";
            this.rateCmbBox.Size = new System.Drawing.Size(121, 24);
            this.rateCmbBox.TabIndex = 15;
            // 
            // releaseCmbBox
            // 
            this.releaseCmbBox.DropDownHeight = 80;
            this.releaseCmbBox.FormattingEnabled = true;
            this.releaseCmbBox.IntegralHeight = false;
            this.releaseCmbBox.Location = new System.Drawing.Point(142, 201);
            this.releaseCmbBox.MaxDropDownItems = 4;
            this.releaseCmbBox.MaxLength = 4;
            this.releaseCmbBox.Name = "releaseCmbBox";
            this.releaseCmbBox.Size = new System.Drawing.Size(121, 24);
            this.releaseCmbBox.TabIndex = 14;
            // 
            // yearLbl
            // 
            this.yearLbl.AutoSize = true;
            this.yearLbl.Location = new System.Drawing.Point(38, 204);
            this.yearLbl.Name = "yearLbl";
            this.yearLbl.Size = new System.Drawing.Size(98, 17);
            this.yearLbl.TabIndex = 13;
            this.yearLbl.Text = "Release Date:";
            // 
            // genreLbl
            // 
            this.genreLbl.AutoSize = true;
            this.genreLbl.Location = new System.Drawing.Point(84, 176);
            this.genreLbl.Name = "genreLbl";
            this.genreLbl.Size = new System.Drawing.Size(52, 17);
            this.genreLbl.TabIndex = 12;
            this.genreLbl.Text = "Genre:";
            // 
            // titleLbl
            // 
            this.titleLbl.AutoSize = true;
            this.titleLbl.Location = new System.Drawing.Point(56, 148);
            this.titleLbl.Name = "titleLbl";
            this.titleLbl.Size = new System.Drawing.Size(80, 17);
            this.titleLbl.TabIndex = 11;
            this.titleLbl.Text = "Movie Title:";
            // 
            // genreTxtBox
            // 
            this.genreTxtBox.Location = new System.Drawing.Point(142, 173);
            this.genreTxtBox.MaxLength = 255;
            this.genreTxtBox.Name = "genreTxtBox";
            this.genreTxtBox.Size = new System.Drawing.Size(195, 22);
            this.genreTxtBox.TabIndex = 10;
            // 
            // titleTxtBox
            // 
            this.titleTxtBox.Location = new System.Drawing.Point(142, 145);
            this.titleTxtBox.MaxLength = 255;
            this.titleTxtBox.Name = "titleTxtBox";
            this.titleTxtBox.Size = new System.Drawing.Size(195, 22);
            this.titleTxtBox.TabIndex = 9;
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(197, 261);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(121, 23);
            this.deleteBtn.TabIndex = 18;
            this.deleteBtn.Text = "Delete Movie";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // ModifyEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 440);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.rateLbl);
            this.Controls.Add(this.modifyBtn);
            this.Controls.Add(this.rateCmbBox);
            this.Controls.Add(this.releaseCmbBox);
            this.Controls.Add(this.yearLbl);
            this.Controls.Add(this.genreLbl);
            this.Controls.Add(this.titleLbl);
            this.Controls.Add(this.genreTxtBox);
            this.Controls.Add(this.titleTxtBox);
            this.Name = "ModifyEntry";
            this.Text = "Modify Movie Entry";
            this.Load += new System.EventHandler(this.ModifyEntry_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label rateLbl;
        private System.Windows.Forms.Button modifyBtn;
        private System.Windows.Forms.ComboBox rateCmbBox;
        private System.Windows.Forms.ComboBox releaseCmbBox;
        private System.Windows.Forms.Label yearLbl;
        private System.Windows.Forms.Label genreLbl;
        private System.Windows.Forms.Label titleLbl;
        private System.Windows.Forms.TextBox genreTxtBox;
        private System.Windows.Forms.TextBox titleTxtBox;
        private System.Windows.Forms.Button deleteBtn;
    }
}