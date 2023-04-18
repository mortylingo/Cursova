using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver;
namespace WindowsFormsApp1.classes.dataclasses
{
    public class User
    {
        [BsonId]
        public ObjectId Id { get; set; }
        [BsonElement]
        public string name;
        [BsonElement]
        public string surname;
        [BsonElement]
        public string login;
        [BsonElement]
        public string password;
        [BsonElement]
        public List<Truck> trucks = new List<Truck>();
        public User(string _name,string _surname,string _login,string _password){ 
            name = _name;
            surname = _surname;
            login = _login;
            password = _password;
        }
        public void AddTruck(Truck _truck)
        {
            trucks.Add(_truck);
            DatabaseController _db = new DatabaseController();
            _db.updateUser(this);
        }
        public Truck getTruck(string plates)
        {
            foreach(var truck in this.trucks)
            {
                if (truck.Plates == plates)
                {
                    return truck;
                }
            }
            return null;
        }
        public void RemoveTruck(string _plates)
        {
            foreach(var truck in trucks)
            {
                if (truck.Plates == _plates)
                {
                    trucks.Remove(truck);
                    DatabaseController _db = new DatabaseController();
                    _db.updateUser(this);
                    return;
                }
            }
        }
    }
}
