using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static UnityEditor.Progress;

public class OnUseClick : MonoBehaviour
{
    public ItemObject item;
    public InventoryObject inventory;
    public PlayerAcsion Player;
    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    public void ButtonClick()
    {
        inventory.UseItem(item);
        Player.UseItem(item.ItemID);
    }
}
