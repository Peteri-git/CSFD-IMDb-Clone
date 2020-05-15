using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace CSFD
{
    public partial class MovieForm : Form
    {
        public MovieForm(string name, string link, List<string> actors, string description, List<string> genres,
            List<string> relatedMovies, string type, string movieFile,string rating,string username, MoviesEntities db)
        {
            InitializeComponent();
            winFormMPlayerControl1.MPlayerPath = @"C:\Users\Petr\Desktop\MPlayer-corei7-r38152+gcc50d113c8\mplayer.exe";
            if (movieFile != null)
                winFormMPlayerControl1.VideoPath = movieFile;
            else
                winFormMPlayerControl1.Enabled = false;
            this.name = name;
            nameBox.Text = this.name;
            this.link = link;
            this.username = username;
            this.type = type.Trim();
            this.genres = genres;
            this.actors = actors;
            this.rating.Text = rating;
            this.relatedMovies = relatedMovies;
            this.description = description;
            if (this.type == "f")
                Text = name + "(Film)";
            else if (this.type == "s")
                Text = name + "(Seriál)";
            linkLabel.Text = "odkaz na IMDb";
            foreach (var actor in actors)
                actorList.Items.Add(actor);
            foreach (var genre in genres)
                genreList.Items.Add(genre);
            foreach (var relatedMovie in relatedMovies)
                relatedMovList.Items.Add(relatedMovie);
            descriptionBox.Text = description;
            this.db = db;
        }

        public string username { get; set; }
        public MoviesEntities db { get; set; }
        public string name { get; set; }
        public string link { get; set; }
        public List<string> actors { get; set; }
        public string description { get; set; }
        public List<string> genres { get; set; }
        public List<string> relatedMovies { get; set; }
        public string type { get; set; }

        private void linkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel.LinkVisited = true;
            Process.Start(link);
        }

        private void actorList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            foreach (var actor in db.Actor)
                if (actor.name == actorList.SelectedItem.ToString())
                {
                    var test = actor.Movie;
                    var movies = new List<string>();
                    if (test != null)
                        foreach (var movie in test)
                            movies.Add(movie.name);
                    var pForm = new ProfileForm(Image.FromFile(actor.photo), actor.name, movies,username);
                    pForm.Show();
                    break;
                }
        }

        private void relatedMovList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            foreach (var movie in db.Movie)
                if (movie.name == relatedMovList.SelectedItem.ToString())
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
                    break;
                }
        }

        private void genreButton_CheckedChanged(object sender, EventArgs e)
        {
            addBox.Items.Clear();
            foreach (var genre in db.Genre)
                addBox.Items.Add(genre.name);
        }

        private void relatedButton_CheckedChanged(object sender, EventArgs e)
        {
            addBox.Items.Clear();
            foreach (var movie in db.Movie)
                addBox.Items.Add(movie.name);
        }

        private void actorButton_CheckedChanged(object sender, EventArgs e)
        {
            addBox.Items.Clear();
            foreach (var actor in db.Actor)
                addBox.Items.Add(actor.name);
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (genreButton.Checked && addBox.SelectedItem != null)
            {
                var genre = addBox.SelectedItem.ToString();
                genres.Add(genre);
                genreList.Items.Add(genre);
                var current = new Movie();
                var add = new Genre();
                foreach (var movie in db.Movie)
                    if (movie.name == name)
                        current = movie;
                foreach (var genre1 in db.Genre)
                    if (genre1.name == genre)
                        add = genre1;
                if (!current.Genre.Contains(add))
                    current.Genre.Add(add);
                db.SaveChanges();
            }
            if (relatedButton.Checked && addBox.SelectedItem != null)
            {
                var relatedMovie = addBox.SelectedItem.ToString();
                var add = new Movie();
                var current = new Movie();
                foreach (var movie in db.Movie)
                {
                    if (movie.name == relatedMovie)
                        add = movie;
                    if (movie.name == name)
                        current = movie;
                }
                if (!current.Movie1.Contains(add))
                {
                    relatedMovies.Add(relatedMovie);
                    relatedMovList.Items.Add(relatedMovie);
                    current.Movie1.Add(add);
                    db.SaveChanges();
                }
            }
            if (actorButton.Checked && addBox.SelectedItem != null)
            {
                var actor = addBox.SelectedItem.ToString();
                var current = new Movie();
                var add = new Actor();
                foreach (var movie in db.Movie)
                    if (movie.name == name)
                        current = movie;
                foreach (var actor1 in db.Actor)
                    if (actor1.name == actor)
                        add = actor1;
                if (!current.Actor.Contains(add))
                {
                    actorList.Items.Add(add.name);
                    actors.Add(add.name);
                    current.Actor.Add(add);
                }
                db.SaveChanges();
            }
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            if (genreButton.Checked && addBox.SelectedItem != null)
            {
                var genre = addBox.SelectedItem.ToString();
                genres.Remove(genre);
                genreList.Items.Remove(genre);
                var tmp = new Genre();
                foreach (var movie in db.Movie)
                    if (movie.name == name)
                    {
                        foreach (var genres in movie.Genre)
                            if (genres.name == genre)
                                tmp = genres;
                        movie.Genre.Remove(tmp);
                    }
                db.SaveChanges();
            }
            if (relatedButton.Checked && addBox.SelectedItem != null)
            {
                var relatedMovie = addBox.SelectedItem.ToString();
                var add = new Movie();
                var current = new Movie();
                foreach (var movie in db.Movie)
                {
                    if (movie.name == relatedMovie)
                        add = movie;
                    if (movie.name == name)
                        current = movie;
                }
                relatedMovies.Remove(relatedMovie);
                relatedMovList.Items.Remove(relatedMovie);
                current.Movie1.Remove(add);
                db.SaveChanges();
            }
            if (actorButton.Checked && addBox.SelectedItem != null)
            {
                var actor = addBox.SelectedItem.ToString();
                var current = new Movie();
                var add = new Actor();
                foreach (var movie in db.Movie)
                    if (movie.name == name)
                        current = movie;
                foreach (var actor1 in current.Actor)
                    if (actor1.name == actor)
                        add = actor1;
                actorList.Items.Remove(add.name);
                actors.Remove(add.name);
                current.Actor.Remove(add);
                db.SaveChanges();
            }
        }

        private void nameBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                var tmp = new Movie();
                foreach (var movie in db.Movie)
                    if (movie.name == name)
                        tmp = movie;
                tmp.name = nameBox.Text;
                name = nameBox.Text;
                db.SaveChanges();
            }
        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK && openFileDialog1.FileName.EndsWith(".mkv"))
            {
                var tmp = Path.GetFileName(openFileDialog1.FileName);
                foreach (var movie in db.Movie)
                    if (movie.name == name)
                    {
                        movie.movieFile = tmp;
                        winFormMPlayerControl1.VideoPath = tmp;
                        winFormMPlayerControl1.Enabled = true;
                    }
            }
            db.SaveChanges();
        }

        private void descriptionBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                var tmp = new Movie();
                foreach (var movie in db.Movie)
                    if (movie.name == name)
                        tmp = movie;
                tmp.description = descriptionBox.Text;
                description = descriptionBox.Text;
                db.SaveChanges();
            }
        }

        private void editLink_Click(object sender, EventArgs e)
        {
            linkEdit le = new linkEdit(this,db,name);
            le.Show();
        }

        private void numericUpDown1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                int id = 2694;
                foreach (var movie in db.Movie)
                    if (movie.name == name)
                        id = movie.id;
                foreach (var account in db.account)
                {
                    if (account.name == username)
                    {
                        foreach (var edit in db.personalEdit)
                            if (edit.accountID != account.id && edit.movieID != id)
                            {
                                account.personalEdit.Add(new personalEdit(account.id, id,
                                    Convert.ToInt32(numericUpDown1.Text), dateTimePicker1.Text));
                                break;
                            }
                            else if (edit.accountID == account.id && edit.movieID == id)
                            {
                                edit.rating = Convert.ToInt32(numericUpDown1.Text);
                                edit.datetime = dateTimePicker1.Text;
                                break;
                            }

                    }
                }
                db.SaveChanges();
                Tuple<float,int> tmp = new Tuple<float, int>(0,0);
                int i = 0;
                int ratingSum = 0;
                foreach(var edit in db.personalEdit)
                    if (edit.movieID == id)
                    {
                        i++;
                        ratingSum += Convert.ToInt32(edit.rating);
                    }
                tmp = new Tuple<float, int>(Convert.ToInt32(ratingSum), i);
                foreach (var movie in db.Movie)
                {
                    if (movie.name == name)
                    {
                        movie.rating = (tmp.Item1 / tmp.Item2).ToString();
                        rating.Text = movie.rating;
                    }
                }
                db.SaveChanges();
            }
        }

        private void nameBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            aliases aliases = new aliases(name, db);
            aliases.Show();
        }
    }
}