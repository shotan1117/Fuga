using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class DisplayInventory : MonoBehaviour
{
    public Text description;
    public InventoryObject inventory;
    public int X_START;
    public int Y_START;

    public int X_SPACE_BETWEEN_ITEM;
    public int NUMBER_OF_COLUMN;
    public int Y_SPACE_BETWEEN_ITEMS;

    public Dictionary<InventorySlot,GameObject> itemDisplayed
        = new Dictionary<InventorySlot,GameObject>();
    // Start is called before the first frame update
    void Start()
    {
        CreateDisplay();      
    }

    // Update is called once per frame
    void Update()
    {
        UpdateDisplay();
    }

    public void UpdateDisplay()
    {
        for(int i =0;i<inventory.container.Count;i++)
        {
            
            if (itemDisplayed.ContainsKey(inventory.container[i]))
            {
                //itemDisplayed[inventory.container[i]].GetComponentInChildren<TextMeshProUGUI>().text=
                 //   inventory.container[i].amount.ToString("n0");
            }
            else
            {
                var obj = Instantiate(inventory.container[i].Item.prefab,
                Vector3.zero, Quaternion.identity, transform);
                
                obj.GetComponent<RectTransform>().localPosition
                    = GetPosition(i);

               // obj.GetComponentInChildren<TextMeshProUGUI>().text =
                   // inventory.container[i].amount.ToString("n0");
                itemDisplayed.Add(inventory.container[i], obj);

                var icon = obj.GetComponent<ItemUIIcon>();
                icon.item = inventory.container[i].Item;
                icon.D_inventory = this;
            }
        }
    }

    public void CreateDisplay()
    {
        for(int i =0;i<inventory.container.Count;i++)
        {
            var obj = Instantiate(inventory.container[i].Item.prefab,
                Vector3.zero,Quaternion.identity,transform);

            obj.GetComponent<RectTransform>().localPosition
                =GetPosition(i);

           // obj.GetComponentInChildren<TextMeshProUGUI>().text=
              //  inventory.container[i].amount.ToString("n0");
        }
    }

    public Vector3 GetPosition (int i )
    {
        return new Vector3(
           X_START+ (X_SPACE_BETWEEN_ITEM * (i % NUMBER_OF_COLUMN)),
           Y_START+ (-Y_SPACE_BETWEEN_ITEMS * (i / NUMBER_OF_COLUMN)),
            0f
            );
    }

    public void SelectItem(ItemObject item)
    {
        description.text = item.description;
        
    }
}
