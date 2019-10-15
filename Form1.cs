using System;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CatalogApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        //Database Connection String to be accessed  whenever manipulating the DB
        public static string connectionString = "server=10.3.129.141;database=catalog;user id=lindahlish;password=Password01;";
        public static MySqlConnection conn = new MySqlConnection(connectionString);
        public static MySqlDataReader reader;

        private void Form1_Load(object sender, EventArgs e)
        {

            try
            {
                GetMovies();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not open connection!" + ex);
            }
        }

        public static int getRowCount()
        {
            int rows = 0;
            MySqlCommand selectData;
            selectData = conn.CreateCommand();
            selectData.CommandText = "SELECT COUNT(*) FROM movies;";

            conn.Open();
            reader = selectData.ExecuteReader();
            while (reader.Read())
            {
                rows = reader.GetInt32(0);
            }
            Console.WriteLine(rows);
            reader.Close();
            conn.Close();

            return rows;
        }

        public static List<Movie> GetMovies()
        {
            List<Movie> movieList = new List<Movie>();
            Movie movie;
            const string query = "SELECT * FROM movies;";
            MySqlCommand command = new MySqlCommand(query, conn);

            try
            {
                using (command)
                {
                    conn.Open();
                    reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        movie = new Movie();
                        movie.movieID = reader.GetInt32(0);
                        movie.title = reader.GetString(1);
                        movie.genre = reader.GetString(2);
                        movie.year = reader.GetInt32(3);
                        movie.rating = reader.GetString(4);
                        movieList.Add(movie);
                    }

                    reader.Close();
                    conn.Close();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("It NO WORK", ex.ToString());
            }

            return movieList;

        }

        private void entryBtn_Click(object sender, EventArgs e)
        {
            NewEntry entryForm = new NewEntry();
            entryForm.ShowDialog();
        }

        private void displayBtn_Click(object sender, EventArgs e)
        { 
            try
            {
                int size = getRowCount();
                string query = "SELECT * FROM movies;";
                MySqlCommand command = new MySqlCommand(query, conn);

                List<Movie> movieList = new List<Movie>();
                movieList = GetMovies();

                foreach (var item in movieList)
                {
                    string[] row = { Convert.ToString(item.movieID), item.title, item.genre, Convert.ToString(item.year), item.rating };
                    var listItem = new ListViewItem(row);
                    int compare = String.Compare(listItem.SubItems[0].Text, Convert.ToString(item.movieID));

                    if (listView1.Items.Count != size)
                    {
                        listView1.Items.Add(listItem);
                    }
                    else
                    {
                        break;
                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(Convert.ToString(ex));
            }
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {

        }

        private void searchTxtBox_TextChanged(object sender, EventArgs e)
        {
            searchLbl.Visible = false;
        }
    }
}
