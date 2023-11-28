using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEditor;
using UnityEngine;

public class OnMergeClick : MonoBehaviour
{
    public InventoryObject player_inv;
    public bool clicked=false;
    public ItemObject item1;
    public ItemObject item2;
   public  ItemObject MergedItem;

    public DisplayInventory d_inv;
    // Start is called before the first frame update
    void Start()
    {
        
    }

   void Update()
    {
        if (clicked)
        {
            if (item1 != null && item2 != null)

            {
                if (item1.ItemID == 1 && item2.ItemID == 2)
                {
                    print("?!?!?!");
                    Destroy(GameObject.Find("Prefab1"+"(Clone)"));
                    Destroy(GameObject.Find("Prefab2" + "(Clone)"));
                    player_inv.AddItem(MergedItem, 1);
                    for (int i = 0; i < player_inv.container.Count; i++)
                    {
                        if (player_inv.container[i].Item == item1)
                        {
                            player_inv.container.Remove(player_inv.container
                               [i]);
                            d_inv.itemDisplayed.Remove(player_inv.container[i]);



                        }
                    }
                    for (int i = 0; i < player_inv.container.Count; i++)
                    {
                        if (player_inv.container[i].Item == item2)
                        {
                            player_inv.container.Remove(player_inv.container
                                [i]);
                            d_inv.itemDisplayed.Remove(player_inv.container[i]);


                        }
                    }


                    clicked = false;
                }

                if (item1.ItemID == 2 && item2.ItemID ==1)
                {
                    print("?!?!?!");
                    Destroy(GameObject.Find("Prefab1" + "(Clone)"));
                    Destroy(GameObject.Find("Prefab2" + "(Clone)"));
                    player_inv.AddItem(MergedItem, 1);
                    for (int i = 0; i < player_inv.container.Count; i++)
                    {
                        if (player_inv.container[i].Item == item1)
                        {
                            player_inv.container.Remove(player_inv.container
                               [i]);
                            d_inv.itemDisplayed.Remove(player_inv.container[i]);



                        }
                    }
                    for (int i = 0; i < player_inv.container.Count; i++)
                    {
                        if (player_inv.container[i].Item == item2)
                        {
                            player_inv.container.Remove(player_inv.container
                                [i]);
                            d_inv.itemDisplayed.Remove(player_inv.container[i]);


                        }
                    }


                    clicked = false;
                }
            }
        }
    }

    public void OnMergeClickkk()
    {
        if(clicked==false)
        {
            clicked = true;
        }
      

       
    }
}
