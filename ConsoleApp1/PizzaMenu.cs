using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class PizzaMenu
    {
        Dictionary<int, Pizza> _menu = new();

        public void Add(int number, Pizza pizza)
        {
            _menu[number] = pizza;
        }
        public void PrintMenu()
        {
            Console.WriteLine("Pizza Menu:");
            Console.WriteLine("------------");
            foreach (var item in _menu)
            {
                Console.WriteLine($"{item.Key}: {item.Value} DKK");
            }
            Console.WriteLine("------------");
        }
        public Pizza? GetPizza(int number)
        {
            if (_menu.ContainsKey(number))
            {
                return _menu[number];
            }
            return null;
        }

        public void Remove(int number)
        {
            if (_menu.ContainsKey(number))
            {
                _menu.Remove(number);
            }
        }
    }
}
