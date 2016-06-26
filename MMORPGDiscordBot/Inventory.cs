using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MMORPGDiscordBot
{
    class Inventory
    {
        //List of items
        public ConcurrentBag<ItemObject> items = new ConcurrentBag<ItemObject>();

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
        public bool AddItem(ItemObject itemToAdd)
        {
            if(items.Count == 0)
            {
                items.Add(itemToAdd);
            }
            foreach (ItemObject itemObject in items)
            {
                if (itemToAdd.item.ToString().Equals(itemObject.item.ToString()))
                {
                    Console.WriteLine("Increasing amount");
                    itemObject.amount++;
                    return true;
                }
            }
            items.Add(itemToAdd);
            return true;    
        }

        //Rmoves item
        public void RemoveItem(ItemObject itemToAdd)
        {
            
        }
    }
}
