using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OnUseClick : MonoBehaviour
{
    public ItemObject item;
    public InventoryObject inventory;
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
        Debug.Log("a");
        inventory.UseItem(item);
    }
}
