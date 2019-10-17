using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CatalogApp
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }

    }



    public class Movie
    {

        public int movieID { get; set; }
        public string title { get; set; }
        public string genre { get; set; }
        public int year { get; set; }
        public string rating { get; set; }

        public Movie()
        {

        }

        public Movie(int movieID, string title, string genre, int year, string rating)
        {
            this.movieID = movieID;
            this.title = title;
            this.genre = genre;
            this.year = year;
            this.rating = rating;
        }

    }

    public class IDException : Exception
    {
        public IDException(string message) : base(message)
        {

        }
    }

}
