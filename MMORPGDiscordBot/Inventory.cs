using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MMORPGDiscordBot
{
    class Inventory
    {
        //List of items
        public List<ItemObject> items = new List<ItemObject>();

        //Gets items based on input
        public ItemObject GetItem(ItemObject item)
        {
            foreach (var itemFound in items)
            {
                if (itemFound == item)
                {
                    return itemFound;
                }
            }
            return null;
        }

        //Adds item
        public void AddItem(ItemObject itemToAdd)
        {
            if(items.Count != 0)
            {
                for (int i = 0; i < items.Count; i++)
                {
                    if (items[i].item == itemToAdd.item)
                    {
                        items[i].amount++;
                        Console.WriteLine("increaseing amount");
                    }
                    else
                    {
                        items.Add(itemToAdd);
                        Console.WriteLine("Adding new item");
                    }
                }
            }
            else
            {
                items.Add(itemToAdd);
            }
        }

        //Rmoves item
        public void RemoveItem(ItemObject itemToAdd)
        {
            for (int i = 0; i < items.Count; i++)
            {
                if (items[i].item == itemToAdd.item)
                {
                    items[i].amount--;
                }
                else
                {
                    items.Remove(itemToAdd);
                }
            }
        }

        //ListToString
    }
}
