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
    [SerializeField]
     ItemObject[] MergedItem;
   
    public DisplayInventory d_inv;


    public int[,] mergeList = new int[30, 30];
    // Start is called before the first frame update
    void Start()
    {
        mergeList[3, 5] = 8;
        mergeList[5, 3] = 8;
        mergeList[10, 11] = 12;
        mergeList[11, 10] = 12;
        mergeList[14, 15] = 16;
        mergeList[15, 14] = 16;
        mergeList[18, 19] = 20;
        mergeList[19, 18] = 20;

        
    }

   void Update()
    {
        if (clicked)
        {
            if (item1 != null && item2 != null)

            {
                if (mergeList[item1.ItemID, item2.ItemID] != 0
                    ||
                    mergeList[item2.ItemID, item1.ItemID] != 0
                    )
                {
                    
                    for(int i = 0; i <MergedItem.Length; i++)
                    {
                        if (MergedItem[i].ItemID== mergeList[item1.ItemID, item2.ItemID])
                        {
                            player_inv.AddItem(MergedItem[i], 1);
                        }
                    }
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
                    Destroy(GameObject.Find(item1.name + "(Clone)"));
                    Destroy(GameObject.Find(item2.name + "(Clone)"));
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
