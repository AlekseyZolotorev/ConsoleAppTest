using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppTest
{
    internal class Money : Item
    {
        public Money(string name, string description, ItemType itemType, bool isStackable, int count) : base(name, description, itemType, isStackable, count)
        {
        }
    }
}
