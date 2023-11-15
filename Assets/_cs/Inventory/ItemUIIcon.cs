using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemUIIcon : MonoBehaviour
{
    public ItemObject item;
    public DisplayInventory D_inventory;
    public InventoryObject player_inv;
    public void SetItemInfo(ItemObject item_)
    {
        item = item_;
    }

    public void OnPointerEnter()
    {
        D_inventory.SelectItem(item);

        
    }
  
}
