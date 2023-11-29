using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum ItemType
{
    Food,
    Equipment,
    Default
}

public abstract class ItemObject : ScriptableObject
{
    public GameObject prefab;
    public ItemType type;
    [SerializeField]
    public int ItemID;
    [TextArea(1, 20)]
    public string name;
    [TextArea(15,20)]
    public string description;
    public bool used = false;
}
