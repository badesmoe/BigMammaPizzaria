using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class CustomerFile
    {
        private List<Customer> _customers = new();

        public void Add(Customer customer)
        {
            _customers.Add(customer);
        }

        public void Remove(Customer customer)
        {
            for (int i = 0; i < _customers.Count; i++)
            {
                if (_customers[i].Name == customer.Name)
                {
                    _customers.RemoveAt(i);
                }
            }
        }

        public void PrintAll()
        {
            Console.WriteLine("Customer List:");
            Console.WriteLine("--------------");
            foreach (var customer in _customers)
            {
                Console.WriteLine(customer.ToString());
            }
            Console.WriteLine("--------------");
        }


        public Customer? Search(string name)
        {
            foreach (var customer in _customers)
            {
                if (customer.Name == name)
                {
                    return customer;
                }
            }
            return null;
        }
    }
}