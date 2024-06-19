using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppTest
{
    internal class Amulet : Item
    {
        public Amulet(string name, string description, ItemType itemType, bool isStack, int count) : base(name, description, itemType, isStack, count)
        {

        }
    }
}
