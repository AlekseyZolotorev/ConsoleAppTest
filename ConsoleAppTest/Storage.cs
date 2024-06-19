using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppTest
{
    public class Storage:IStorage
    {
        private  List<Item> _items;
        public string _name;
        public string Name
        {
            get 
            { 
                return _name; 
            }
        }
        public Storage(string name) 
        { 
            _name = name;
            _items = new List<Item>();
        }       

        public void AddItem(Item item)
        {           
            _items.Add(item);
            Console.WriteLine($"{item.Name} added to {Name} ");
        }

        public void RemoveItem(Item item)
        {
            _items.Remove(item);
            Console.WriteLine($"{item.Name} removed from {Name}");
        }

        public List<Item> GetItems()
        {
            return _items;
        }
    }
}
