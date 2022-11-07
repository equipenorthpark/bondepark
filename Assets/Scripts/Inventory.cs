﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory
{
    private List<Item> itemList;

    public Inventory()
    {
        itemList = new List<Item>();

        AddItem(new Item { itemType = Item.ItemType.ChaveDeFenda, amount = 1});
        AddItem(new Item { itemType = Item.ItemType.Pincel, amount = 1});
        AddItem(new Item { itemType = Item.ItemType.Rolo, amount = 1});
        AddItem(new Item { itemType = Item.ItemType.Martelo, amount = 1});
        
    }

    public void AddItem(Item item)
    {
        itemList.Add(item);
    }

    public List<Item> GetItemList()
    {
        return itemList;
    }
}
