using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Customer
    {
        private int Id;
        public int CustomerID
        {
            get { return Id; }
            set { Id = value; }
        }
        public string CustomerName { get; set; } = "New customer";
        public void Print()
        {
            Console.WriteLine($"ID:{CustomerID}, Name:{CustomerName}");
        }
    }
}
