using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Pizza
    {
        private int _id;
        private static int _nextID;
        public int ID { get { return _id; } }
        public string Name { get; set; }
        public double Price { get; set; }

        public Pizza(string name, double price)
        {
            _nextID++;
            _id = _nextID;
            Name = name;
            Price = price;
        }

        public override string ToString()
        {
            return $"{Name}: {Price}";
        }
    }
}
