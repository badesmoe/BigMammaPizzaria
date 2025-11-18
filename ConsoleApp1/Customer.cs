using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Customer
    {
        private int _id;
        private static int _nextID;

        public int ID { get { return _id; } }
        public string Name { get; set; }
        public string Address { get; set; }
        public int Phone { get; set; }

        public Customer(string name, string address, int phone)
        {
            Name = name;
            Address = address;
            Phone = phone;
            _nextID++;
            _id = _nextID;
        }

        public override string ToString()
        {
            return $"Customer nr: {_id}:\nName: {Name}\nAddress: {Address}\nPhone: {Phone}\n";
        }
    }
}
