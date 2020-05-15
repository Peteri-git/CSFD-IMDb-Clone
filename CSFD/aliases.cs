using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSFD
{
    public partial class aliases : Form
    {
        public string movieName { get; set; }
        public MoviesEntities db { get; set; }
        public int movieID { get; set; }
        public aliases(string movieName,MoviesEntities db)
        {
            InitializeComponent();
            this.movieName = movieName;
            this.db = db;
            this.movieID = movieID;
            foreach (var movie in db.Movie)
            {
                if (movie.name == movieName)
                {
                    if (movie.movieAliases != null)
                    {

                    }
                }
            }

        }

        private void add_Click(object sender, EventArgs e)
        {
        }
    }
}
