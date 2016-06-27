using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MMORPGDiscordBot
{
    enum ItemType
    {
        Wood,
        Ore,
        Gold,
        Null
    };
    class Inventory
    {
        //Dictionary of items and their quanity
        public ConcurrentDictionary<ItemType, int> items = new ConcurrentDictionary<ItemType, int>();

        //Add item to inventory
        public void AddItem(ItemType itemType, int quantity)
        {
            if (!items.ContainsKey(itemType))
            {
                items.AddOrUpdate(itemType, quantity,(key,oldValue)=> { return oldValue; });
            }
            else
            {
                items[itemType] += quantity;
            }
        }

        //Find itemtype by string
        public static ItemType GetItemTypeByString(string itemType)
        {
            if(itemType.ToLower().Contains("wood"))
            {
                return ItemType.Wood;
            }
            else if (itemType.ToLower().Contains("ore"))
            {
                return ItemType.Ore;
            }
            else if (itemType.ToLower().Contains("gold"))
            {
                return ItemType.Gold;
            }
            else
            {
                return ItemType.Null;
            }
        }
    }
}
