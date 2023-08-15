using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern
{
    internal class Item
    {
        public string Name { get; set; }
        public Item(string name) 
        {
            Name= name;
        }

        public void Display()
        {
            Console.WriteLine(Name + " Handheld Inventory");
        }
    }
}
