using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppTest
{
    public abstract class Item:IItem
    {
        private string _name { get; set; }
        public string Name
        {
            get
            {
                return _name;
            }           
        } 
        
        public string Description { get; set; }
        private ItemType _itemType { get; set; }
        public ItemType ItemType
        {
            get
            {
                return _itemType;
            }
        }
        
        public bool IsStackable { get; set; }
        public int Count { get; set; }

        public Item(string name, string description, ItemType itemType, bool isStackable, int count)
        { 
            _name = name;
            Description = description;
            _itemType = itemType;
            IsStackable = isStackable;
            Count = count;
        }

        public virtual void Drop()
        {

        }       

        public virtual void Take()
        {
           
        }
    }

    public enum ItemType
    {
        None, money, books, amulets, weapons, clothes
    }
}

