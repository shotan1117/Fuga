using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

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
        GameObject.Find("Button_Use").GetComponent<OnUseClick>()
            .item = item;
        GameObject.Find("Item_Image").GetComponent<itemImage>().item = item;


        GameObject.Find("Item_Image").GetComponent<Image>().sprite =
       GameObject.Find(item.name + "(Clone)").GetComponent<Image>().sprite;

        if (GameObject.Find("Button_Merge").GetComponent<OnMergeClick>()
            .clicked==false)
        {
            GameObject.Find("Button_Merge").GetComponent<OnMergeClick>()
           .item1 = item;
        }else if(GameObject.Find("Button_Merge").GetComponent<OnMergeClick>()
            .clicked == true
            )
        {
            GameObject.Find("Button_Merge").GetComponent<OnMergeClick>()
           .item2= item;
        }
        GameObject.Find("Item_Image").GetComponent<Image>().sprite = null;
    }
  
}
