using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

/*
              * 
              * 
              * https://www.youtube.com/watch?v=_IqTeruf3-s
              * 
              * 
              */


[CreateAssetMenu(fileName = "New Inventory", menuName = "Inventory System/Inventory")]
public class InventoryObject : ScriptableObject
{
   public List<InventorySlot> container = new List<InventorySlot>();
    public void AddItem(ItemObject _item,int _amount)
    {
        bool hasItem = false;
        for(int i =0;i<container.Count;i++)
        {
            if (container[i].Item==_item)
            {
                container[i].AddAmount(_amount);


             
                hasItem = true;
                break;
            }
            
        }
        if (!hasItem)
        {
            container.Add(new InventorySlot(_item, _amount));
        }
    }
}

[System.Serializable]
public class InventorySlot
{
    public ItemObject Item;
    public int amount;
    public InventorySlot(ItemObject _item,int _amount)
    {
       this.Item = _item;
        this.amount = _amount;  
    }

    public void AddAmount(int value)
    {
        amount += value;
    }
}
