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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        //Database Connection String to be accessed  whenever manipulating the DB
        public static string connectionString = "server=192.168.183.11;database=catalog;user id=lindahlish;password=Password01;";
        public static MySqlConnection conn = new MySqlConnection(connectionString);
        public static MySqlDataReader reader;

        //Test Connection to DB on Loading the application.
        private void Form1_Load(object sender, EventArgs e)
        {
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

        //Gets the number of rows (aka movies) in the DB to set limit in loops. 
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

            reader.Close();
            conn.Close();

            return rows;
        }

        //Method to run when getting data from the MariaDB which then creates object instances of the "movie" class.
        public static List<Movie> GetMovies(ListView listView1)
        {
            List<Movie> movieList = new List<Movie>();
            Movie movie;
            const string query = "SELECT * FROM movies ORDER BY title ASC;";
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

                    listView1.Items.Clear();
                    foreach (var item in movieList)
                    {
                        string[] row = { Convert.ToString(item.movieID), item.title, item.genre, Convert.ToString(item.year), item.rating };
                        var listItem = new ListViewItem(row);
                        listView1.Items.Add(listItem);
                    }

                    if(movieList.Count == 0)
                    {
                        Console.WriteLine("OH NO, LIST HAVE NO STUFF");
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

        // Method to perform a query on the DB and return data to the form
        public static bool QueryDB(string searchData, bool titleBut, bool genreBut, ListView listView1)
        {
            List<Movie> movieList = new List<Movie>();
            Movie movie;
            string query;
            MySqlCommand command;

            //Check if the user entered anything into the search box
            if (!String.IsNullOrEmpty(searchData))
            {
                //Search by movie title
                if (titleBut == true)
                {
                    query = $"SELECT * FROM movies WHERE title LIKE '%{searchData}%' ORDER BY title ASC;";
                    command = new MySqlCommand(query, conn);

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

                else if (genreBut == true)
                {
                    query = $"SELECT * FROM movies WHERE genre LIKE '%{searchData}%' ORDER BY title ASC;";
                    command = new MySqlCommand(query, conn);

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

                else
                {
                    return false;
                }

                //Add the new movieList to the listView
                int size = movieList.Count;

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

                return true;
            }
            //return false if search box text is null or both radio buttons are null
            return false;
        }

        //Event that creates the form to allow user to enter a new movie into the catalog.
        private void entryBtn_Click(object sender, EventArgs e)
        {
            NewEntry entryForm = new NewEntry();
            entryForm.ShowDialog();
            //GetMovies(listView1);
        }

        //Event that displays all of the movies currently in the catalog in the listview.
        private void displayBtn_Click(object sender, EventArgs e)
        { 
            try
            {

                GetMovies(listView1);

            }
            catch (Exception ex)
            {
                MessageBox.Show(Convert.ToString(ex));
            }
        }

        //Event that searches through the catalog based on input placed in the textbox and which radio button is selected (title or genre).
        private void searchBtn_Click(object sender, EventArgs e)
        {
            bool unitTest1;
            bool titleBut = this.titleRdBtn.Checked;
            bool genreBut = this.genreRdBtn.Checked;
            string searchData = this.searchTxtBox.Text;

            listView1.Items.Clear();
            unitTest1 = QueryDB(searchData, titleBut, genreBut, listView1);
        }

        //Clears the label in the Search Textbox when the user starts typing. 
        private void searchTxtBox_TextChanged(object sender, EventArgs e)
        {
            searchLbl.Visible = false;
        }

        //String that will be used by Form 3.
        public static string setTitle, setGenre, setRelease, setRating, movieID;
        //Event that allows the user to select a specific movie and either delete or modify that movie. 
        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            ListView.SelectedListViewItemCollection movie = this.listView1.SelectedItems;
            foreach(ListViewItem item in movie)
            {
                for(int i = 0; i <= item.SubItems.Count; i++)
                {
                    movieID = item.SubItems[0].Text;
                    setTitle = item.SubItems[1].Text;
                    setGenre = item.SubItems[2].Text;
                    setRelease = item.SubItems[3].Text;
                    setRating = item.SubItems[4].Text;
                }
            }

            ModifyEntry modifyForm = new ModifyEntry();
            modifyForm.ShowDialog();
            GetMovies(listView1);

        }
    }
}
