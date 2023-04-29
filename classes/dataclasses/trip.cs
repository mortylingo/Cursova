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
            cargo = new Cargo(_name, _mass, _price);
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
        public Cargo(string name, double mass, double price)
        {
            Mass = mass;
            Price = price;
            Name = name;
        }
        [BsonElement]
        public string Name;
        [BsonElement]
        public double Mass;
        [BsonElement]
        public double Price;

    }
}
