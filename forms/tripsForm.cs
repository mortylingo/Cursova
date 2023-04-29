using Microsoft.Extensions.Logging.Abstractions;
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
using System.Xml.Serialization;
using WindowsFormsApp1.classes;
using WindowsFormsApp1.classes.dataclasses;

namespace WindowsFormsApp1.forms
{
    public partial class tripsForm : Form
    {
        DatabaseController _db = new DatabaseController();
        private User currentUser;
        private string currentPlates;
        public tripsForm(User usr, string plates)
        {
            this.currentPlates = plates;
            this.currentUser = usr;
            InitializeComponent();
        }

        private void tripsForm_Load(object sender, EventArgs e)
        {
            _db.readTrips(dataGridView1, currentUser, currentPlates);
            Custom custom = new Custom(dataGridView1);
            dataGridView1.Columns[0].Width = 170;
            dataGridView1.Columns[1].Width = 170;
            dataGridView1.Columns[2].Width = 170;
            dataGridView1.Columns[3].Width = 80;
            dataGridView1.Columns[4].Width = 80;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Trip trip = new Trip(startPointField.Text, endPointField.Text, cargoField.Text, Convert.ToDouble(priceField.Text), Convert.ToDouble(massField.Text));
            var userCollection = _db.GetCollection();
            foreach (var truck in currentUser.trucks)
            {
                if (truck.Plates == currentPlates)
                {
                    truck.Trips.Add(trip);
                    _db.updateUser(currentUser);
                }
            }
            MessageBox.Show("Поїздку успішно добавлено");          
            _db.readTrips(dataGridView1, currentUser, currentPlates);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Trip trip = new Trip(startPointField.Text, endPointField.Text, cargoField.Text, Convert.ToDouble(priceField.Text), Convert.ToDouble(massField.Text));           
            var userCollection = _db.GetCollection();
            foreach (var truck in currentUser.trucks)
            {
                if (truck.Plates == currentPlates)
                {
                    truck.Trips.Remove(trip);
                    _db.updateUser(currentUser);
                }
            }
            MessageBox.Show("Поїздку успішно видалено");
            _db.readTrips(dataGridView1, currentUser, currentPlates);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = dataGridView1.CurrentCell.RowIndex;
            startPointField.Text = Convert.ToString(dataGridView1.Rows[rowIndex].Cells[0].Value);
            endPointField.Text = Convert.ToString(dataGridView1.Rows[rowIndex].Cells[1].Value);
            cargoField.Text = Convert.ToString(dataGridView1.Rows[rowIndex].Cells[2].Value);
            priceField.Text = Convert.ToString(dataGridView1.Rows[rowIndex].Cells[3].Value);
            massField.Text = Convert.ToString(dataGridView1.Rows[rowIndex].Cells[4].Value);
        }

        private void backToTruck_click(object sender, EventArgs e)
        {
            trucksForm form = new trucksForm(currentUser);
            this.Hide(); form.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            searchForm form = new searchForm(currentPlates, currentUser);
            form.Show();
        }

        private void tripsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            trucksForm form = new trucksForm(currentUser);
            form.Show();
        }

        
        private void startPointField_Enter(object sender, EventArgs e)
        {
            startPointField.Text = null;
        }
        private void endPointField_Enter(object sender, EventArgs e)
        {
            endPointField.Text = null;
        }
        private void priceField_Enter(object sender, EventArgs e)
        {
            priceField.Text = null; 
        }
        private void cargoField_Enter(object sender, EventArgs e)
        {
            cargoField.Text = null;
        }
        private void massField_Enter(object sender, EventArgs e)
        {
            massField.Text = null;  
        }

        private void startPointField_Leave(object sender, EventArgs e)
        {
            if (startPointField.Text == "")
            {
                startPointField.Text = "Місце завантаження";
            }
        }

        private void endPointField_Leave(object sender, EventArgs e)
        {
            if (endPointField.Text == "")
            {
                endPointField.Text = "Місце вивантаження";
            }
        }

        private void cargoField_Leave(object sender, EventArgs e)
        {
            if (cargoField.Text == "")
            {
                cargoField.Text = "Вантаж";
            }
        }

        private void priceField_Leave(object sender, EventArgs e)
        {
            if (priceField.Text == "")
            {
                priceField.Text = "Ціна";
            }
        }

        private void massField_Leave(object sender, EventArgs e)
        {
            if (massField.Text == "")
            {
                massField.Text = "Вага";
            }
        }
    }
}
