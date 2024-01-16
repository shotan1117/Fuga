using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerTest : MonoBehaviour
{
    //public InventoryObject inventory;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter(Collider other)//item ÇÅ@ÉQÉbÉg
    {
        var item = other.GetComponent<item>();
        if(item)
        {
            //inventory.AddItem(item.itemm, 1);
            Destroy(other.gameObject);
        }
    }

    private void OnApplicationQuit()
    {
        //inventory.container.Clear();
        //inventory.Using_Item = null;
        //inventory.Merging_Item_First = null;
        //inventory.Merging_Item_Second = null;
    }
}
