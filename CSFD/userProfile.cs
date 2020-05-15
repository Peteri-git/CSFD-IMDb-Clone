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
    public partial class userProfile : Form
    {
        public string username { get; set; }
        public MoviesEntities db { get; set; }
        public userProfile(string username,MoviesEntities db)
        {
            InitializeComponent();
            this.username = username;
            this.db = db;
            label1.Text = username;
            foreach (var account in db.account)
            {
                if (account.name == username)
                {
                    foreach (var personalEdit in account.personalEdit)
                    {
                        foreach (var movie in db.Movie)
                        {
                            if (personalEdit.movieID==movie.id)
                            {
                                favoriteMoviesBox.Items.Add($"{movie.name} rating:{personalEdit.rating} naposled shlédnuto:{personalEdit.datetime}");
                            }
                        }
                    }
                }
            }
        }
    }
}
