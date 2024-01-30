using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemUIIcon : MonoBehaviour
{
    public ItemObject item;
    public DisplayInventory D_inventory;

    public void SetItemInfo(ItemObject item_)
    {
        item = item_;
    }

    public void OnPointerEnter()
    {
        D_inventory.SelectItem(item);
       
        if(D_inventory.state==DisplayInventory.State.Select)
        {
            this.GetComponent<Image>().color = new Color(173,216,230,0.5f);
        }
        
    }
   public void  OnPointerExit()
    {
        this.GetComponent<Image>().color = Color.white;
    }
}
