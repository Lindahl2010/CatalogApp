using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using MySql.Data;
using MySql.Data.MySqlClient;
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
        public static string connectionString = "server=192.168.1.25;database=catalog;user id=lindahlish;password=Password01;";
        public static MySqlConnection conn;
        public static MySqlDataReader reader;

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            searchLbl.Visible = false;
        }

        private void entryBtn_Click(object sender, EventArgs e)
        {
            NewEntry entryForm = new NewEntry();
            entryForm.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            conn = new MySqlConnection(connectionString);

            try
            {
                conn.Open();

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not open connection!" + ex);
            }
        }

        private void displayBtn_Click(object sender, EventArgs e)
        {

            try
            {
                int ID;
                string genre, year, rating;
                conn = new MySqlConnection(connectionString);
                string query = "SELECT * FROM movies;";

                List<Movie> movies = new List<Movie>();
                Movie movie;

                using (MySqlCommand command = new MySqlCommand(query, conn))
                {
                    conn.Open();

                    reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        
                        movie = new Movie(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetInt32(3), reader.GetString(4));
                        movies.Add(movie);
                        for(int i = 0; i <= movies.Count() + 1; i++)
                        {
                            Console.WriteLine(i.ToString());
                            Console.WriteLine(movies[i].title);
                        }
                        Console.WriteLine(reader.GetString(1));

                    }

                    reader.Close();

                }
                conn.Close();

                
            }
            catch (Exception ex)
            {
                MessageBox.Show(Convert.ToString(ex));
            }
        }

        private void searchTxtBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
