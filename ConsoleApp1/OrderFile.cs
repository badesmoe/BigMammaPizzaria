using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class OrderFile
    {
        private List<Order> _orderlist = new();

        public void Add(Order order)
        {
            _orderlist.Add(order);
        }

        public void Remove(Order order)
        {
            for (int i = 0; i < _orderlist.Count; i++)
            {
                if (_orderlist[i].ToString() == order.ToString())
                {
                    _orderlist.RemoveAt(i);
                }
            }
        }

        public void PrintAll()
        {
            foreach (var order in _orderlist)
            {
                Console.WriteLine(order.ToString());
            }
        }

        public Order? Search(int id)
        {
            foreach (var order in _orderlist)
            {
                if (order.ToString().Contains($"Order nr: {id}:"))
                {
                    return order;
                }
            }
            return null;
        }

        public double TotalRevenue()
        {
            double total = 0;
            foreach (var order in _orderlist)
            {
                total += order.CalculateTotal();
            }
            return total;
        }

        public double TotalPizzas()
        {
            double total = 0;
            foreach (var order in _orderlist)
            {
                total++;
            }
            return total;
        }
    }

}