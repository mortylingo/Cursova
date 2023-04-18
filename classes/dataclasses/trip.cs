using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.classes.dataclasses
{
    public class Trip
    {
        public Trip(string _start,string _end, string _name, double _mass, double _price) { 
            cargo = new Cargo(_mass, _price, _name);
            StartingPoint = _start;
            EndingPoint = _end;
        }
        [BsonElement]
        public string StartingPoint;
        [BsonElement] 
        public string EndingPoint;
        [BsonElement]
        public Cargo cargo;
    }
    public class Cargo
    {
        public Cargo(double mass, double price, string name)
        {
            Mass = mass;
            Price = price;
            Name = name;
        }
        [BsonElement]
        public double Mass;
        [BsonElement]
        public double Price;
        [BsonElement]
        public string Name;

    }
}
