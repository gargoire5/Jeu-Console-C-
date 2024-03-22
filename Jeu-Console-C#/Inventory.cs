using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Jeu_Console_C_
{
    internal class Inventory
    {
        private List<Items> items = new List<Items>();

        public void AddItems(Items item, int quantity = 1)
        {
            Items existingItem = items.Find(i => i.Name == item.Name);
            if (existingItem != null)
            {
                existingItem.Quantity = quantity;
            }
            else
            {
                item.Quantity = quantity;
                items.Add(item);
            }
            
        }

        public void RemoveItems(Items item)
        {
            items.Remove(item);
        }

        public int countItem(Items itemType)
        {
            return items.Count(items => items.GetType() == itemType.GetType());
        }

        public void DisplayInventorry()
        {
            Console.WriteLine("Inventaire :");
            Console.WriteLine();

            for (int i = 0; i < items.Count; i++)
            {
                Items Currentitem = items[i];
                Console.WriteLine($"{i + 1}. {Currentitem.Name} (x{Currentitem.Quantity})");
            }
        }
    }
}