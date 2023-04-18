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
    public partial class searchForm : Form
    {
        private User currentUser;
        private string currentPlates;
        public searchForm(string plate, User user)
        {
            this.currentUser = user;
            this.currentPlates = plate;
            InitializeComponent();
            this.Size = new System.Drawing.Size(800,150);
            comboBox1.Items.AddRange(new string[] {"Місце завантаження","Місце вивантаження","Ціна","Вантаж"});
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DatabaseController _db = new DatabaseController();
            this.Size = new System.Drawing.Size(800, 350);
            _db.searchResults(dataGridView1, currentUser, comboBox1.SelectedIndex, textBox1.Text,currentPlates);
        }
    }
}
