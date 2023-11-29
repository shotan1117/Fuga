using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using Unity.VisualScripting.FullSerializer;
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
    public ItemObject Using_Item;
    public ItemObject Merging_Item_First;
    public ItemObject Merging_Item_Second;
    
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

    public void RemoveItem(ItemObject _item)
    {
        for (int i = 0; i < container.Count; i++)
        {
            if (container[i].Item == _item)
            {
                container[i]=null;
                

                break;
            }

        }

    }

    public void UseItem(ItemObject _item)
    {
        Using_Item= _item;
        Debug.Log(_item.name+"‚ðŽg‚Á‚Ä‚¢‚é!");
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
