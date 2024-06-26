using Scenes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Jeu_Console_C_
{
    internal class Inventory
    {
        private List<Items> items = new List<Items>();
        private int selectedItemIndex = 0;

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

        public void RemoveSelectedItem()
        {
            if (selectedItemIndex >= 0 && selectedItemIndex < items.Count)
            {
                items.RemoveAt(selectedItemIndex);
                selectedItemIndex = 0;
            }
            else
            {
                Console.WriteLine("Aucun élément sélectionné.");
            }
        }

        public int countItem(Items itemType)
        {
            return items.Count(items => items.GetType() == itemType.GetType());
        }

        public void DisplayInventory()
        {
            Console.WriteLine("Inventaire :");
            Console.WriteLine();

            for (int i = 0; i < items.Count; i++)
            {

                if (i == selectedItemIndex)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                }

                Items Currentitem = items[i];
                Console.WriteLine($"{i + 1}. {Currentitem.Name} (x{Currentitem.Quantity})");

                Console.ResetColor();
            }
        }

        public void MoveSelectionUp()
        {
            selectedItemIndex = Math.Max(0, selectedItemIndex - 1);
        }

        public void MoveSelectionDown()
        {
            selectedItemIndex = Math.Min(items.Count - 1, selectedItemIndex + 1);
        }

        public Items GetSelectedItem()
        {
            if (selectedItemIndex >= 0 && selectedItemIndex < items.Count)
            {
                return items[selectedItemIndex];
            }
            else
            {
                Console.WriteLine("Aucun élément sélectionné.");
                return null;
            }
        }

    }
}
