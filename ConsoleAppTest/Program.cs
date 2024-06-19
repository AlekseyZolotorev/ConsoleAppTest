namespace ConsoleAppTest
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleApp consoleApp = new ConsoleApp();
            consoleApp.Run();
            Console.WriteLine("List of Command : take, exit, table , inventory, list");

            while (true)
            {
               
                Console.WriteLine("Enter command");
                string command = Console.ReadLine();               
                switch (command.ToLower())
                {
                    case "take":
                        Console.WriteLine("Enter the name of item: ");
                        string itemName = Console.ReadLine();

                        Item itemToTake = consoleApp.table.GetItems().FirstOrDefault(i => i.Name.ToLower() == itemName.ToLower());
                        if (itemToTake != null)
                        {
                            consoleApp.table.RemoveItem(itemToTake);
                            consoleApp.playerInventory.AddItem(itemToTake);
                            Console.WriteLine($"You just taked {itemToTake.Name}");
                        }
                        else
                        {
                            Console.WriteLine($"There is no  {itemName} on table.");
                        }
                        break;

                    case "exit":
                        Console.Clear();
                        Console.WriteLine("App closed");
                        return;
                    case "table":
                        Console.WriteLine(consoleApp.GetItemsOnTable());
                        break;
                    case "inventory":
                        Console.WriteLine(consoleApp.GetPlayerInventory());
                        break;
                    case "list":
                        Console.WriteLine("List of Command : take, exit, table , inventory, list");
                        break;
                    default:
                        Console.WriteLine("Unknow command");
                        break;
                }
            }
        }
    }
}