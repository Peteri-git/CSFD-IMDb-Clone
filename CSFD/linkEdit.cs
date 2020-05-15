using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSFD
{
    public partial class linkEdit : Form
    {
        public MovieForm MovieForm { get; set; }
        public MoviesEntities db { get; set; }
        public string name { get; set; }
        public linkEdit(MovieForm MovieForm,MoviesEntities db,string name)
        {
            InitializeComponent();
            this.MovieForm = MovieForm;
            this.db = db;
            this.name = name;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach(var movie in db.Movie)
                if (movie.name == name)
                    movie.link = textBox1.Text;
            MovieForm.link = textBox1.Text;
            db.SaveChanges();
            this.Close();   
        }
    }
}
