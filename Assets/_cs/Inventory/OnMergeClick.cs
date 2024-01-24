using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;
//using static UnityEditor.Progress;

[Serializable]
public class ItemMergeData
{
    public int itemA;
    public int itemB;
    public int result;

    // 指定したアイテムがマージ可能か
    public bool IsMatch(int item1, int item2)
    {
        if (item1 == itemA && item2 == itemB) return true;
        if (item1 == itemB && item2 == itemA) return true;
        return false;
    }

    public ItemMergeData(int A, int B, int r)
    {
        itemA = A;
        itemB = B;
        result = r;
    }
}

public class OnMergeClick : MonoBehaviour
{
    //public InventoryObject player_inv;
    //public bool clicked=false;
    public ItemObject item1;
    public ItemObject item2;
    [SerializeField]
     ItemObject[] MergedItem;
   
    public DisplayInventory d_inv;

    public List<ItemMergeData> mergeList = new List<ItemMergeData>();

    // Start is called before the first frame update
    void Start()
    {
        // マージリスト生成
        mergeList.Add(new ItemMergeData(3, 5, 8));
        mergeList.Add(new ItemMergeData(7, 8, 9));
        mergeList.Add(new ItemMergeData(10, 11, 12));
        mergeList.Add(new ItemMergeData(14, 15, 16));
        mergeList.Add(new ItemMergeData(18, 19, 20));
        mergeList.Add(new ItemMergeData(15, 21, 17));
        mergeList.Add(new ItemMergeData(24, 19, 23));
        mergeList.Add(new ItemMergeData(20,24,23));
    }

    ItemMergeData GetMergeData(int itemA, int itemB)
    {
        foreach(var m in mergeList)
        {
            if (m.IsMatch(itemA, itemB)) return m;
        }
        return null;
    }

    // アイテムをマージして新しいアイテムを生み出す
    // 新たに生み出したアイテムを返す
    // 失敗したらnull
    public ItemObject Merge()
    {
        if (item1 == null) return null;
        if (item2 == null) return null;

        // マージデータ取得
        var merge = GetMergeData(item1.ItemID, item2.ItemID);

        if (merge != null)
        {
            for (int i = 0; i < MergedItem.Length; i++)
            {
                if (MergedItem[i].ItemID == merge.result)
                {
                    d_inv.AddItem(MergedItem[i]);
                    d_inv.RemoveItem(item1.ItemID);
                    d_inv.RemoveItem(item2.ItemID);
                    return MergedItem[i];
                }
            }
        }

        return null;
    }

    public void OnMergeClickkk()
    {
        d_inv.MergeStart();
    }
}
