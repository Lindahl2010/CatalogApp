using System;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CatalogApp
{
    public partial class ModifyEntry : Form
    {
        public ModifyEntry()
        {
            InitializeComponent();
        }

        //Database Connection String to be accessed  whenever manipulating the DB
        public static string connectionString = "server=192.168.185.181;database=Catalog;user id=group4;password=CatalogApp;";
        public static MySqlConnection conn = new MySqlConnection(connectionString);
        public static MySqlDataReader reader;

        //Event that sets up the Form when it is loaded.
        private void ModifyEntry_Load(object sender, EventArgs e)
        {

            //Sets Release Year Combo Box with available year options.
            DateTime currentYear = DateTime.Today;
            string date = currentYear.Year.ToString();

            for (int i = Convert.ToInt32(date); i >= 1900; i--)
            {
                releaseCmbBox.Items.Add(i);
            };

            //Sets Rating Combo Box with the available rating options. 
            string[] rating = { "G", "PG", "PG-13", "R", "NC-17", "Not Rated" };
            for (int i = 0; i < rating.Length; i++)
            {
                rateCmbBox.Items.Add(rating[i]);
            };

            this.releaseCmbBox.DropDownStyle = ComboBoxStyle.DropDownList;
            this.rateCmbBox.DropDownStyle = ComboBoxStyle.DropDownList;

            titleTxtBox.Text = MainForm.setTitle;
            genreTxtBox.Text = MainForm.setGenre;
            releaseCmbBox.Text = MainForm.setRelease;
            rateCmbBox.Text = MainForm.setRating;
        }

        //Event that removes the selected movie from the MariaDB.
        private void deleteBtn_Click(object sender, EventArgs e)
        {
            string message = "Are you sure you want to delete this Movie?";
            const string caption = "Delete Movie";
            var result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                string movieID = MainForm.movieID;
                string query = $"DELETE FROM movies WHERE ID = {movieID}";
                MySqlCommand command = new MySqlCommand(query, conn);
                using (command)
                {
                    conn.Open();
                    reader = command.ExecuteReader();
                    reader.Close();
                    conn.Close();
                    this.Close();
                }
            }
            else
            {

            }
        }

        //Event that modifies the movie that the user selected from Form1. 
        private void modifyBtn_Click(object sender, EventArgs e)
        {
            string movieID = MainForm.movieID;
            string query = "UPDATE movies SET title= '" + this.titleTxtBox.Text + "', genre= '" + this.genreTxtBox.Text + "', year= '" + this.releaseCmbBox.Text + "'" +
                ", rating= '" + this.rateCmbBox.Text + $"' WHERE ID = {movieID}";
            MySqlCommand command = new MySqlCommand(query, conn);
            using (command)
            {
                conn.Open();
                reader = command.ExecuteReader();
                reader.Close();
                conn.Close();
                this.Close();
            }
        }
    }
}
