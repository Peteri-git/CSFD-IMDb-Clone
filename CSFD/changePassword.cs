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
    public partial class changePassword : Form
    {
        public string username { get; set; }
        public MoviesEntities db { get; set; }
        public changePassword(string username,MoviesEntities db)
        {
            InitializeComponent();
            this.username = username;
            this.db = db;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (passwordBox.Text == passwordChkBox.Text)
            {
                foreach (var account in db.account)
                {
                    if (account.name == username)
                    {
                        account.password = Cryptography.Encrypt(passwordBox.Text);
                    }   
                }
            }
            db.SaveChanges();
            this.Close();
        }
    }
}
