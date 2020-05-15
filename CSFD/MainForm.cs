using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TMDbLib.Client;
using OMDbApiNet;
using TMDbLib.Objects.Lists;

namespace CSFD
{
    public partial class MainForm : Form
    {
        MoviesEntities db = new MoviesEntities();
        OmdbClient client = new OmdbClient("41b0e8e2");
        public string username { get; set; }
        public MainForm(string username)
        {
            InitializeComponent();
            this.username = username;
            this.Cursor = new Cursor("sword.cur");
            foreach (var movie in db.Movie)
            {
                FilteredList.Items.Add(movie.name);
            }
            foreach (var actor in db.Actor)
            {
                FilteredList.Items.Add(actor.name);
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (Movies.Checked == true)
            {
                db.Movie.Add(new Movie(addBox.Text,"f"));
                FilteredList.Items.Add(addBox.Text);
                db.SaveChangesAsync();
            }
            if (Shows.Checked == true)
            {
                db.Movie.Add(new Movie(addBox.Text,"s"));
                FilteredList.Items.Add(addBox.Text);
                db.SaveChangesAsync();
            }
            if (Actors.Checked == true)
            {
                if (openFileDialog1.ShowDialog()==DialogResult.OK)
                {
                    string tmp = Path.GetFileName(openFileDialog1.FileName);
                    db.Actor.Add(new Actor(addBox.Text, tmp));
                    FilteredList.Items.Add(addBox.Text);
                    db.SaveChanges();
                }
            }
        }

        private void Movies_CheckedChanged(object sender, EventArgs e)
        {
            FilteredList.Items.Clear();
            foreach (var movie in db.Movie)
            {
                var type = movie.type.Trim();
                if (type == "f")
                {
                    FilteredList.Items.Add(movie.name);
                }
            }
        }

        private void Shows_CheckedChanged(object sender, EventArgs e)
        {
            FilteredList.Items.Clear();
            foreach (var movie in db.Movie)
            {
                var type = movie.type.Trim();
                if (type == "s")
                {
                    FilteredList.Items.Add(movie.name);
                }
            }
        }

        private void Actors_CheckedChanged(object sender, EventArgs e)
        {
            FilteredList.Items.Clear();
            foreach (var actor in db.Actor)
            {
                FilteredList.Items.Add(actor.name);
            }
        }
        private void userButton_CheckedChanged(object sender, EventArgs e)
        {
            FilteredList.Items.Clear();
            foreach (var account in db.account)
            {
                FilteredList.Items.Add(account.name);
            }
        }

        private void FilteredList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (Actors.Checked == true)
            {
                foreach (var actor in db.Actor)
                {
                    if (actor.name == FilteredList.SelectedItem.ToString())
                    {
                        ICollection<Movie> test = actor.Movie;
                        List<string> movies = new List<string>();
                        if (test != null)
                        {
                            foreach (var movie in test)
                            {
                                movies.Add(movie.name);
                            }
                        }
                        ProfileForm pForm = new ProfileForm(Image.FromFile(actor.photo), actor.name, movies,username);
                        pForm.Show();
                    }
                }
            }
            else if (userButton.Checked == true)
            {
                foreach (var account in db.account)
                {
                    if (account.name == FilteredList.SelectedItem.ToString())
                    {
                        userProfile uP = new userProfile(account.name,db);
                        uP.Show();
                    }
                }
            }
            else
            {
                foreach (var movie in db.Movie)
                {
                    if (movie.name == FilteredList.SelectedItem.ToString())
                    {
                        ICollection<Actor> test = movie.Actor;
                        List<string> actors = new List<string>();
                        List<string> genres = new List<string>();
                        List<string> relMovies = new List<string>();
                        if (test != null)
                        {
                            foreach (var actor in test)
                            {
                                actors.Add(actor.name);
                            }
                        }
                        ICollection<Genre> tmp = movie.Genre;
                        if (tmp != null)
                        {
                            foreach (var genre in tmp)
                            {
                                genres.Add(genre.name);
                            }
                        }
                        ICollection<Movie> rel = movie.Movie1;
                        if (rel != null)
                        {
                            foreach (var relMovie in rel)
                            {
                                relMovies.Add(relMovie.name);
                            }
                        }
                        MovieForm mf = new MovieForm(movie.name, movie.link, actors, movie.description, genres, relMovies,movie.type,movie.movieFile,movie.rating,username,db);
                        mf.Show();
                    }
                }

            }
        }

        private void changePasswordBtn_Click(object sender, EventArgs e)
        {
            changePassword change = new changePassword(username,db);
            change.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var item = client.GetItemByTitle(searchBox.Text);
            List<string> currentMovies = new List<string>();
            foreach (var movies in db.Movie)
                currentMovies.Add(movies.name);
            if (!(currentMovies.Contains(item.Title)))
            {
                List<string> currentActors = new List<string>();
                List<string> currentGenres = new List<string>();
                string type;
                if (item.Type == "series")
                {
                    type = "s";
                }
                else
                {
                    type = "f";
                }
                var movie = new Movie(item.Title, type, item.Plot);
                movie.Actor = new List<Actor>();
                movie.Genre = new List<Genre>();
                foreach (var actor in db.Actor)
                    currentActors.Add(actor.name);
                foreach (var genre in db.Genre)
                    currentGenres.Add(genre.name);
                var split = item.Actors.Split(',');
                var genres = item.Genre.Split(',');
                foreach (var actor in split)
                {
                    var tmp = actor.Trim();
                    var add = new Actor(tmp, "default.jpg");
                    if (!(currentActors.Contains(tmp)))
                    {
                        movie.Actor.Add(add);
                        db.SaveChanges();
                    }
                    else
                    {
                        foreach (var actor1 in db.Actor)
                        {
                            if (actor1.name == actor)
                            {
                                movie.Actor.Add(actor1);
                                db.SaveChanges();
                            }
                        }
                    }
                }
                foreach (var genre in genres)
                {
                    var tmp = genre.Trim();
                    Genre add = new Genre(tmp);
                    if (!(currentGenres.Contains(tmp)))
                    {
                        movie.Genre.Add(add);
                        db.SaveChanges();
                    }
                    else
                    {
                        foreach (var genre1 in db.Genre)
                        {
                            if (genre1.name == genre)
                            {
                                movie.Genre.Add(genre1);
                            }
                        }
                    }
                }
                db.Movie.Add(movie);
                db.SaveChanges();
                this.Text = "movie added";
            }
            else
            {
                this.Text = "movie not added";
            }
        }
    }
}
