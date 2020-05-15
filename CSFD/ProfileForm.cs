using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace CSFD
{
    public partial class ProfileForm : Form
    {
        private readonly MoviesEntities db = new MoviesEntities();

        public ProfileForm(Image ProfImage, string Name, List<string> Movies,string username)
        {
            InitializeComponent();
            Text = Name;
            this.Movies = Movies;
            this.username = username;
            name = Name;
            ProfileImage.SizeMode = PictureBoxSizeMode.StretchImage;
            ProfileImage.Image = ProfImage;
            NameBox.Text = name;
            foreach (var movie in this.Movies)
                MoviesList.Items.Add(movie);
            foreach (var movie in db.Movie)
                MovieBox.Items.Add(movie.name);
        }

        public string username { get; set; }
        public List<string> Movies { get; set; }
        public string name { get; set; }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!Movies.Contains(MovieBox.SelectedItem))
            {
                Movies.Add(MovieBox.SelectedItem.ToString());
                MoviesList.Items.Add(MovieBox.SelectedItem);
                foreach (var movie in db.Movie)
                    if (movie.name == MovieBox.SelectedItem.ToString())
                        foreach (var actor in db.Actor)
                            if (actor.name == Name)
                                actor.Movie.Add(movie);
                db.SaveChangesAsync();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MoviesList.Items.Contains(MovieBox.SelectedItem))
            {
                Movies.Remove(MovieBox.SelectedItem.ToString());
                MoviesList.Items.Remove(MovieBox.SelectedItem);
                foreach (var movie in db.Movie)
                    if (movie.name == MovieBox.SelectedItem.ToString())
                        foreach (var actor in db.Actor)
                            if (actor.name == Name)
                                actor.Movie.Add(movie);
                db.SaveChangesAsync();
            }
        }

        private void ProfileImage_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK && openFileDialog1.FileName.EndsWith(".jpg"))
            {
                var tmp = Path.GetFileName(openFileDialog1.FileName);
                ProfileImage.Image = Image.FromFile(tmp);
                foreach (var actor in db.Actor)
                    if (actor.name == Name)
                        actor.photo = tmp;
            }
            db.SaveChanges();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            foreach (var actor in db.Actor)
                if (actor.name == Name)
                {
                    Name = NameBox.Text;
                    actor.name = NameBox.Text;
                }
            db.SaveChangesAsync();
            Refresh();
        }

        private void MoviesList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            foreach (var movie in db.Movie)
                if (movie.name == MoviesList.SelectedItem.ToString())
                {
                    var test = movie.Actor;
                    var actors = new List<string>();
                    var genres = new List<string>();
                    var relMovies = new List<string>();
                    if (test != null)
                        foreach (var actor in test)
                            actors.Add(actor.name);
                    var tmp = movie.Genre;
                    if (tmp != null)
                        foreach (var genre in tmp)
                            genres.Add(genre.name);
                    var rel = movie.Movie1;
                    if (rel != null)
                        foreach (var relMovie in rel)
                            relMovies.Add(relMovie.name);
                    var mf = new MovieForm(movie.name, movie.link, actors, movie.description, genres, relMovies,
                        movie.type, movie.movieFile,movie.rating,username,db);
                    mf.Show();
                }
        }
    }
}