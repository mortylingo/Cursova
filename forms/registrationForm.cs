using Amazon.Runtime.Internal.Util;
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
    public partial class registrationForm : Form
    {
        public registrationForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DatabaseController _db = new DatabaseController();
            User usr = new User(nameField.Text, surnameField.Text, loginField.Text, regField.Text);
            try
            {
                _db.InsertUser(usr);
                loginForm form = new loginForm();
                form.Show();
                this.Hide();
            }
            catch
            {
                return;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            loginForm form = new loginForm();
            form.Show();
            this.Hide();
        }

        private void regField_Click(object sender, EventArgs e)
        {
            regField.Text = null;
        }

        private void loginField_Click(object sender, EventArgs e)
        {
            loginField.Text = null;
        }

        private void nameField_Click(object sender, EventArgs e)
        {
            nameField.Text = null;
        }

        private void surnameField_Click(object sender, EventArgs e)
        {
            surnameField.Text = null;
        }
    }
}
