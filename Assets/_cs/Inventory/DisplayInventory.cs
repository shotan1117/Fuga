using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class DisplayInventory : MonoBehaviour
{
    ItemObject nowItem = null;
    public Transform listParent;
    public Text description;
    public OnMergeClick onMergeClick;
    public OnUseClick onUseClick;
    public itemImage itemImg;

    Dictionary<int, GameObject> itemIconList = new Dictionary<int, GameObject>();

    public enum State
    {
        None,   // �����I�����Ă��Ȃ�
        Select, // �A�C�e���I��
        Merge,  // �}�[�W�A�C�e���I��
    }
    public State state = State.None;

    void Start()
    {    
    }

    public void AddItem(ItemObject i)
    {
        if (itemIconList.ContainsKey(i.ItemID)) return;

        var obj = Instantiate(i.prefab, Vector3.zero,Quaternion.identity, listParent);
        itemIconList.Add(i.ItemID, obj);

        var itemUIIcon = obj.GetComponent<ItemUIIcon>();
        itemUIIcon.item = i;
        itemUIIcon.D_inventory = this;
    }

    public void RemoveItem(int itemID)
    {
        if(itemIconList.ContainsKey(itemID))
        {
            Destroy(itemIconList[itemID]);
            itemIconList.Remove(itemID);
        }
    }

    // �g�ݍ��킹�{�^�����������Ƃ��̏���
    public void MergeStart()
    {
        onMergeClick.item1 = nowItem;
        state = State.Merge;
    }

    public void SelectItem(ItemObject item)
    {
        switch(state)
        {
            case State.None:
                ApplyItem(item);
                state = State.Select;
                break;
            case State.Select:
                ApplyItem(item);
                break;
            case State.Merge:
                onMergeClick.item2 = item;
                var newItem = onMergeClick.Merge();
                state = State.Select;
                // �}�[�W������������V�A�C�e����I��
                if (newItem != null)
                {
                    ApplyItem(newItem);
                }
                break;
        }
    }

    void ApplyItem(ItemObject item)
    {
        nowItem = item;
        description.text = item.description;
        onUseClick.item = item;
        itemImg.item = item;
        itemImg.num = item.ItemID;
    }
}
