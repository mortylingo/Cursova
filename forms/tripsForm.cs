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
    }
}
