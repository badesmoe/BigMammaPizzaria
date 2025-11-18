using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Order
    {
        private int _id;
        private static int _nextID;
        private const double tax = 1.25;
        private const double deliveryCost = 40;
        public Pizza Pizza;
        public Customer Customer;
        public DateTime OrderTime { get; } = DateTime.Now;
        public Order(Customer customer, Pizza pizza)
        {
            _nextID++;
            _id = _nextID;
            Customer = customer;
            Pizza = pizza;
        }

        public double CalculateTotal()
        {
            return (Pizza.Price * tax) + deliveryCost;
        }

        public override string ToString()
        {
            return $"Order nr: {_id}:\nCustomer: {Customer.Name}\nPizza: {Pizza.Name}\nTotal Price (incl. tax and delivery): {CalculateTotal()} DKK\n";
        }
    }
}
