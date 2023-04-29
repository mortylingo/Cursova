using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.classes;
using WindowsFormsApp1.classes.dataclasses;
namespace WindowsFormsApp1.forms
{
    public partial class trucksForm : Form
    {
        DatabaseController _db = new DatabaseController();
        private User currentUser;
        public trucksForm(User current)
        {
            this.currentUser = current;
            InitializeComponent();
        }

        private void trucksForm_Load(object sender, EventArgs e)
        {
            _db.readTrucks(dataGridView1, currentUser);
            Custom customize = new Custom(dataGridView1);
            dataGridView1.Columns[0].Width = 200;
            dataGridView1.Columns[1].Width = 140;
            dataGridView1.Columns[2].Width = 140;
            dataGridView1.Columns[3].Width = 140;
        }

        //Додавання вантажівки
        private void button2_Click(object sender, EventArgs e)
        {
            Truck truck = new Truck(driverField.Text, modelField.Text, manufacturerField.Text, plateField.Text, currentUser);           
            var userCollection = _db.GetCollection();
            var truckExists = userCollection.Find(u => u.trucks.Any(t => t.Plates == plateField.Text)).Any();
            if (truckExists)
            {
                MessageBox.Show("Вантажівка з данними номерами вже існує");
                return;
            }
            currentUser.AddTruck(truck);
            MessageBox.Show("Вантажівку успішно добавлено");
            _db.readTrucks(dataGridView1, currentUser);                     
        }

        //Видалення вантажівки
        private void button3_Click(object sender, EventArgs e)
        {
            Truck truck = new Truck(driverField.Text, modelField.Text, manufacturerField.Text, plateField.Text, currentUser);
            try
            {
                var userCollection = _db.GetCollection();
                var truckExists = userCollection.Find(u => u.trucks.Any(t => t.Plates == plateField.Text)).Any();
                if (!truckExists)
                {
                    MessageBox.Show("Такої вантажівки не існує");
                    return;
                }
                currentUser.RemoveTruck(plateField.Text);
                _db.updateUser(currentUser);
                MessageBox.Show("Вантажівку успішно видалено");
                _db.readTrucks(dataGridView1, currentUser);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //Перегляд поїздок
        private void button1_Click(object sender, EventArgs e)
        {
            int rowIndex = dataGridView1.CurrentCell.RowIndex;
            string indexPlates = Convert.ToString(dataGridView1.Rows[rowIndex].Cells[3].Value);
            tripsForm form = new tripsForm(currentUser, indexPlates);
            form.Show();
            this.Hide();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = dataGridView1.CurrentCell.RowIndex;
            driverField.Text = Convert.ToString(dataGridView1.Rows[rowIndex].Cells[0].Value);
            manufacturerField.Text = Convert.ToString(dataGridView1.Rows[rowIndex].Cells[1].Value);
            modelField.Text = Convert.ToString(dataGridView1.Rows[rowIndex].Cells[2].Value);
            plateField.Text = Convert.ToString(dataGridView1.Rows[rowIndex].Cells[3].Value);
        }

        private void trucksForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void driverField_Enter(object sender, EventArgs e)
        {
            driverField.Text = null;
        }

        private void manufacturerField_Enter(object sender, EventArgs e)
        {
            manufacturerField.Text = null;
        }

        private void modelField_Enter(object sender, EventArgs e)
        {
            modelField.Text = null;
        }

        private void plateField_Enter(object sender, EventArgs e)
        {
            plateField.Text = null;
        }

        private void driverField_Leave(object sender, EventArgs e)
        {
            if(driverField.Text == "")
            {
                driverField.Text = "Введіть водія";
            }
        }

        private void manufacturerField_Leave(object sender, EventArgs e)
        {
            if (manufacturerField.Text == "")
            {
                manufacturerField.Text = "Введіть марку";
            }
        }

        private void modelField_Leave(object sender, EventArgs e)
        {
            if (modelField.Text == "")
            {
                modelField.Text = "Введіть модель";
            }
        }

        private void plateField_Leave(object sender, EventArgs e)
        {
            if (plateField.Text == "")
            {
                plateField.Text = "Введіть номери";
            }
        }
    }
}
