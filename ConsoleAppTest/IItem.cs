using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppTest
{
    public interface IItem
    {
        public void Take();
        public void Drop();
    }

    public interface IStorage
    {
        public void AddItem(Item item);
        public void RemoveItem(Item item);
    }
}
