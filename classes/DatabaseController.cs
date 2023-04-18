using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using MongoDB.Bson;
using System.Security.Policy;
using System.Security.Permissions;
using MongoDB.Driver.Core.Clusters;
using System.Windows.Forms;
using WindowsFormsApp1.classes.dataclasses;
using System.Collections.ObjectModel;
using System.Data;

namespace WindowsFormsApp1.classes
{
    public class DatabaseController
    {
        private IMongoClient _client;
        private IMongoDatabase _database;
        private IMongoCollection<User> _collection;
        public DatabaseController()
        {
            try
            {
                _client = new MongoClient(Environment.GetEnvironmentVariable("mongoString"));
                _database = _client.GetDatabase("main");
                _collection = _database.GetCollection<User>("users");
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public void InsertUser(User user)
        {
            if (_collection.Find(u => u.login == user.login)?.FirstOrDefault()?.login == null){ 
                _collection.InsertOne(user);
                MessageBox.Show("Користувача успішно зареєстровано");
            }
            else
            {
                MessageBox.Show("Такий користувач вже існує!");
            }
        }

        public void readTrucks(DataGridView dgv, User currentUser)
        {
            List<User> users = _collection.Find(u => true).ToList();
            DataTable dt = new DataTable();
            dt.Columns.Add("Водій");
            dt.Columns.Add("Марка");
            dt.Columns.Add("Модель");
            dt.Columns.Add("Номерний знак");
            foreach(var truck in currentUser.trucks)
            {
                dt.Rows.Add(truck.Driver,truck.Manufacturer,truck.Model,truck.Plates);  
            }
            dgv.DataSource = dt;
        }
        public void readTrips(DataGridView dgv, User currentUser, string plate)
        {
            List<User> users = _collection.Find(u => true).ToList();
            DataTable dt = new DataTable();
            dt.Columns.Add("Місце завантаження");
            dt.Columns.Add("Місце вигрузки");
            dt.Columns.Add("Вантаж");
            dt.Columns.Add("Ціна");
            dt.Columns.Add("Вага");
            foreach (var truck in currentUser.trucks)
            {
                if (truck.Plates == plate)
                {
                    foreach(var trip in truck.Trips)
                    {
                        dt.Rows.Add(trip.StartingPoint, trip.EndingPoint, trip.cargo.Name, trip.cargo.Price, trip.cargo.Mass);
                    }
                }
            }
            dgv.DataSource = dt;
        }

        public void searchResults(DataGridView dgv, User currentUser, int choose, string filter, string plate)
        {
            List<User> users = _collection.Find(u => true).ToList();
            DataTable dt = new DataTable();
            dt.Columns.Add("Місце завантаження");
            dt.Columns.Add("Місце вигрузки");
            dt.Columns.Add("Вантаж");
            dt.Columns.Add("Ціна");
            dt.Columns.Add("Вага");
            foreach (var truck in currentUser.trucks)
            {
                if (truck.Plates == plate)
                {
                    foreach (var trip in truck.Trips)
                    {
                        if (trip.EndingPoint == filter && choose == 0)
                        {
                            dt.Rows.Add(trip.StartingPoint, trip.EndingPoint, trip.cargo.Name, trip.cargo.Price, trip.cargo.Mass);
                        }
                        if (trip.StartingPoint == filter && choose == 1)
                        {
                            dt.Rows.Add(trip.StartingPoint, trip.EndingPoint, trip.cargo.Name, trip.cargo.Price, trip.cargo.Mass);
                        }
                        if (trip.cargo.Price == Convert.ToDouble(filter) && choose == 2)
                        {
                            dt.Rows.Add(trip.StartingPoint, trip.EndingPoint, trip.cargo.Name, trip.cargo.Price, trip.cargo.Mass);
                        }
                        if (trip.cargo.Name == filter && choose == 3)
                        {
                            dt.Rows.Add(trip.StartingPoint, trip.EndingPoint, trip.cargo.Name, trip.cargo.Price, trip.cargo.Mass);
                        }
                    }
                }
            }
            dgv.DataSource = dt;

        }

        public User GetUser(string login)
        {
            return _collection.Find(u => u.login == login)?.FirstOrDefault();
        }
        //TODO refresh
        public void updateUser(User usr)
        {
            _collection.DeleteOne(u => u.login == usr.login);
            _collection.InsertOne(usr);

        }
        public IMongoCollection<User> GetCollection()
        {
            return _collection;
        }
    }
}