using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace CSFD
{
    public partial class login : Form
    {
        private bool RegisterClicked;
        private bool LoginClicked;
        private MoviesEntities db = new MoviesEntities();
        public login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RegisterClicked = true;
            LoginClicked = false;
            Register.Enabled = false;
            log.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RegisterClicked = false;
            LoginClicked = true;
            Register.Enabled = true;
            log.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (RegisterClicked == true)
            {
                Dictionary<string, string> accounts = new Dictionary<string, string>();
                foreach (var account in db.account)
                {
                    accounts.Add(account.name.ToString(), account.password.ToString());
                }
                if (accounts.ContainsKey(textBox1.Text))
                {
                    MessageBox.Show("Uživatelské jméno již existuje!");
                }
                else
                {
                    db.account.Add(new account(textBox1.Text, textBox2.Text));
                    db.SaveChangesAsync();
                    MessageBox.Show("Registered!");
                }


            }
            if (LoginClicked == true)
            {
                foreach (var account in db.account)
                {
                    var name = account.name.Trim();
                    var password = account.password.Trim();
                    var tmp = Cryptography.Decrypt(password);
                    if (name == textBox1.Text && password == Cryptography.Encrypt(textBox2.Text))
                    {
                        MessageBox.Show("Logged in!");
                        MainForm form = new MainForm(name);
                        form.Show();
                        //Form1 form = new Form1();
                        //form.nickname = textBox1.Text;
                        //form.Show();
                        this.Hide();
                    }
                }
            }
        }
    }
}
