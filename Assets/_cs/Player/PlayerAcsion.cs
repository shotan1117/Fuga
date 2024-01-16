using NavKeypad;
using SojaExiles;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class PlayerAcsion : MonoBehaviour
{
    [SerializeField]
    AudioClip clip;

    public AudioSource audioSource;

    //アイテムボックス
    public ShowCanvas ShowCanvase;
    //public InventoryObject inventory;
    public DisplayInventory dInventory;

    private Gimmick gimmick;

    public UItext HintoText;
    private void Start()
    {
       
    }
    // Update is called once per frame
    void Update()
    {
        OpenBox();
        //アイテムボックスを開いてるか
        if (Time.timeScale== 0) { return; }   
        {
            float distance = 10;
            RaycastHit hit;
            //コライダーを飛ばしてタグでアイテム判定
            if (Physics.Raycast(Camera.main.transform.position, Camera.main.transform.forward, out hit, distance))
            {
                if (Input.GetMouseButtonDown(0))
                {
                    switch (hit.collider.tag)
                    {
                        case "Item":
                            Itemaddition(hit.collider);
                            break;

                        case "Gimmick":
                            ShowCanvase.OpenItemBox();
                            gimmick = hit.collider.GetComponent<Gimmick>();
                            break;
                    }

                    if (hit.collider.TryGetComponent(out KeypadButton keypadButton))
                    {
                        keypadButton.PressButton();
                    }
                }

                if (hit.collider.tag == "Gimmick")
                {
                    if(HintoText.num == 0)
                    {
                        HintoText.num = hit.collider.GetComponent<Gimmick>().MyItemNo;
                    }
                }
                else
                {
                    HintoText.num = 0;
                }
            }
        }
      
    }

    private void Itemaddition(Collider other)
    {
        //アイテム格納
        var item = other.gameObject.GetComponent<itemData>();
        if (item)
        {
            //inventory.AddItem(item.i, 1);
            dInventory.AddItem(item.i);
            audioSource.PlayOneShot(clip);
            Destroy(other.gameObject);
        }
    }

    private void OpenBox()
    {
        //アイテムボックスを開く
        if (Input.GetButtonDown("Inventory"))
        {
           ShowCanvase.OpenItemBox();
        }
    }

    private void OnApplicationQuit()
    {
        //アイテムボックス内リセット
        //inventory.container.Clear();
        //inventory.Using_Item = null;
        //inventory.Merging_Item_First = null;
        //inventory.Merging_Item_Second = null;
    }

    public void UseItem(int itemID)
    {
        //アイテム使用
        if (gimmick != null)
        {
            gimmick.UseObject(itemID);
            ShowCanvase.OpenItemBox();
        }
    }
}
