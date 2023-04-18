using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace WindowsFormsApp1.classes.dataclasses
{
    public class Truck
    {
        private User currentUser;
        public Truck(string _driver, string _model,string _manufacturer,string _plates, User usr) {
            Driver = _driver;
            Model = _model;
            Manufacturer = _manufacturer;
            Plates = _plates;
            this.currentUser = usr;
        }
        [BsonElement]
        public string Driver;
        [BsonElement] 
        public string Manufacturer;
        [BsonElement]
        public string Model;
        [BsonElement]
        public string Plates;
        [BsonElement]
        public List<Trip> Trips = new List<Trip>();
    }
}
