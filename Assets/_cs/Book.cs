using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Book : MonoBehaviour
{
    public bool isInPlayer;
    public InventoryObject playerInventory;

    private bool isHaveItem;

    // Start is called before the first frame update
    void Start()
    {
        isInPlayer = false;
        isHaveItem = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (isInPlayer)
        {
            for (int i = 0; i < playerInventory.container.Count; i++) 
            {
                if (playerInventory.container[i].Item.ItemID == 200)
                {
                    isHaveItem = true;
                }
            }
            //インベントリ内のアイテムIDをすべて参照＝＞特定のがあればtrue)
            //特定の範囲にいればtrue
            //inventoryで「使う」を押したら、usedがtrueになる
            if (isHaveItem && isInPlayer)
            {
                Destroy(this.gameObject);
                Debug.Log("trueになった！");
            }
        }


    }
}
