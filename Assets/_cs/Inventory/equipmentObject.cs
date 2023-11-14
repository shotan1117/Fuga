using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "equipment Object", menuName = "Inventory System/Items/equipment")]
public class equipmentObject : ItemObject
{
    public int atk;
    public int def;
    // Start is called before the first frame update
    private void Awake()
    {
        type = ItemType.Equipment;
    }
}
