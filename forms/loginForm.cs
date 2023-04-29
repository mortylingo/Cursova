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
        private void loginField_Enter(object sender, EventArgs e)
        {
            loginField.Text = null;
        }

        private void passwordField_Enter(object sender, EventArgs e)
        {
            passwordField.Text = null;
            passwordField.PasswordChar = '*';
        }

        private void passwordField_Leave(object sender, EventArgs e)
        {
            if (passwordField.Text == "")
            {
                passwordField.Text = "Введіть пароль";
                passwordField.PasswordChar = '\0';
            }
        }

        private void loginField_Leave(object sender, EventArgs e)
        {   
            if(loginField.Text == "")
            loginField.Text = "Введіть логін";
        }
    }
}
