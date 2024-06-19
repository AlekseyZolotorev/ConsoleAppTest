using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleAppTest
{
    internal class ConsoleApp
    {
        public Inventory playerInventory = new Inventory("Player Inventory");
        public Table table = new Table("Table");
        private Amulet amulet = new Amulet("Gold amulet", "Rare jewelry" , ItemType.amulets, false, 1);
        private Money cash = new Money("Money", "Means of payment", ItemType.money, true, 30);
        private Book book = new Book("Book", "Book about animals", ItemType.books, false, 1);      

        public void Run()
        {            
            table.AddItem(amulet);
            table.AddItem(cash);
            table.AddItem(book);          
        }

        public string GetItemsOnTable()
        {
            StringBuilder sb = new StringBuilder();
            foreach(var i in table.GetItems())
            {
                sb.Append(i.Name.ToString());
                sb.Append(", ");
            }
            return sb.ToString();
        }
        public string GetPlayerInventory() 
        { 
            StringBuilder sb = new StringBuilder();
            foreach (var i in playerInventory.GetItems())
            {
                sb.Append($"{i.Name}");
                sb.Append(", ");
            }
            return sb.ToString();
        }
    }
}

