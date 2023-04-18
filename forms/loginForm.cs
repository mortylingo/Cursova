using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.classes;
using WindowsFormsApp1.classes.dataclasses;

namespace WindowsFormsApp1.forms
{
    public partial class loginForm : Form
    {
        public loginForm()
        {
            InitializeComponent();
            Config cfg = new Config();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DatabaseController _db = new DatabaseController();
            User usr = _db.GetUser(loginField.Text);
            if (usr.password == passwordField.Text)
            {
                trucksForm form = new trucksForm(usr);
                form.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Введено неправильно логін або пароль");
            }
            
        }

        private void label1_Click(object sender, EventArgs e)
        {
            registrationForm form = new registrationForm();
            form.Show();
            this.Hide();
        }

        private void passwordField_Click(object sender, EventArgs e)
        {
            passwordField.Mask = null;
        }

        private void loginField_Click(object sender, EventArgs e)
        {
            loginField.Text = null;
        }
    }
}
