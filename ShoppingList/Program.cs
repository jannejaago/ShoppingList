using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ShoppingList
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Write your shopping list items seperated by comma and space:");
            string shoppingItems = ReadLine();
            Clear();
            var shoppingList = new List<string>();
            foreach (string item in shoppingItems.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries))
            {
                shoppingList.Add(item);
            }
            WriteShoppingList(shoppingList);
            ReadLine();
        }
        public static void WriteShoppingList(List<string> shoppingList)
        {
            WriteLine("Your shopping list consists of:");
            for(int i=0;i<shoppingList.Count; i++)
            {
                WriteLine($"Item {i + 1}: {shoppingList[i]}");
            }
            WriteLine("If you would like to add an item type 1, if you would like to add an item type 2");
            WriteLine("And if you're done with your shopping list type 3.");
            int userAnwser = int.Parse(ReadLine());
            if (userAnwser == 1)
            {
                AddItem(shoppingList);
            }
            else if (userAnwser == 2)
            {
                RemoveItem(shoppingList);
            }
            else
            {
                ShoppingListDone();
            }
        }
        public static void AddItem(List<string> shoppingList)
        {
            WriteLine("Write an item you would like to add");
            string newItem = ReadLine();
            shoppingList.Add(newItem);
            Clear();
            WriteShoppingList(shoppingList);
        }
        public static void RemoveItem(List<string> shoppingList)
        {
            WriteLine("Write an item you would like to remove");
            string removeItem = ReadLine();
            shoppingList.Remove(removeItem);
            Clear();
            WriteShoppingList(shoppingList);
        }
        public static void ShoppingListDone()
        {
            WriteLine("Shop wisely!");
        }
    }
}
