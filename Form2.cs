using System;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;

namespace CatalogApp
{
    public partial class NewEntry : Form
    {
        public NewEntry()
        {
            InitializeComponent();
        }

        //Database Connection String to be accessed  whenever manipulating the DB
        public static string connectionString = "server=192.168.183.11;database=catalog;user id=lindahlish;password=Password01;";
        public static MySqlConnection conn;
        public static MySqlDataReader reader;

        private void NewEntry_Load(object sender, EventArgs e)
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
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            try
            {
                List<Movie> movies = new List<Movie>();
                //Movie movie;

                string title = this.titleTxtBox.Text;
                string genre = this.genreTxtBox.Text;
                string year = this.releaseCmbBox.Text;
                string rating = this.rateCmbBox.Text;                

                //movie = new Movie(title, genre, Convert.ToInt32(year), rating);
                //movies.Add(movie);
                //for (int i = 0; i <= movies.Count(); i++)
                //{
                //    Console.WriteLine(movies[i]);
                //}

                MySqlConnection conn = new MySqlConnection(connectionString);

                string query = "INSERT INTO catalog.movies(title,genre,year,rating) VALUES('" + this.titleTxtBox.Text + "','" + this.genreTxtBox.Text + "'," +
                    "'" + this.releaseCmbBox.Text + "','" + this.rateCmbBox.Text + "')";
                MySqlCommand command = new MySqlCommand(query, conn);
                MySqlDataReader reader;               

                conn.Open();
                reader = command.ExecuteReader();

                conn.Close();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not open connection! \n" + ex);
            }
        }

    
    }
}
