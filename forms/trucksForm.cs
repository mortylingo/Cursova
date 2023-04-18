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
    }
}
