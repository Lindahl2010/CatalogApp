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
        public static string connectionString = "server=10.3.129.141;database=catalog;user id=lindahlish;password=Password01;";
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
                conn = new MySqlConnection(connectionString);
                string query = "SELECT title FROM movies;";
                MySqlCommand command = new MySqlCommand(query, conn);

                conn.Open();
                using (reader = command.ExecuteReader())
                {
                    while(reader.Read())
                    {

                    }
                }
                conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(Convert.ToString(ex));
            }
        }
    }
}
