using SojaExiles;
using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerAcsion : MonoBehaviour
{
    [SerializeField]
    Transform parentObj;

    [SerializeField]
    BoxCollider BoxCollider;

    [SerializeField]
    Rigidbody parentRigidBody;

    //キャッチしたオブジェクトの取得
    private Rigidbody HaveObject;
    private Collider ObjectCollider;

    //アイテムボックス
    public ShowCanvas ShowCanvase;
    public InventoryObject inventory;

    private void Start()
    {
        BoxCollider.enabled = false;
    }
    // Update is called once per frame
    void Update()
    {
        OpenBox();
        if (Time.timeScale== 0) { return; }
        if (Input.GetMouseButtonDown(0))
        {
            // オブジェクトを持っていないときはオブジェクトを持つ
            if(HaveObject == null)
            {
                float distance = 10;
                var hits = Physics.RaycastAll(Camera.main.transform.position, Camera.main.transform.forward, distance);
                foreach (var hit in hits)
                {
                    if (hit.collider.tag == "Object")
                    {
                        ObjectCatch(hit.collider);
                    }
                    if(hit.collider.tag == "Item")
                    {
                        Itemaddition(hit.collider);
                    }
                }
            }
            // オブジェクトを持っていないときはオブジェクトを離す
            else
            {
                HaveObject.constraints = 0;
                HaveObject.isKinematic = false;
                ObjectCollider.enabled  = true;
                BoxCollider.enabled = false;
                HaveObject.transform.SetParent(null, true);
                HaveObject.velocity = parentRigidBody.velocity;
                HaveObject = null;
                ObjectCollider = null;
            }
        }
      
    }

    private void ObjectCatch(Collider othe)
    {
        //持てるオブジェクト取得
        ObjectCollider = othe;
        HaveObject = ObjectCollider.gameObject.GetComponent<Rigidbody>();
        ObjectCollider.enabled = false;  
        BoxCollider.enabled = true;
        HaveObject.constraints = RigidbodyConstraints.FreezePositionY;
        HaveObject.isKinematic = true;
        HaveObject.transform.SetParent(parentObj.transform, true);
        HaveObject.transform.localPosition = new Vector3(0, 0.1f, 0.3f); 
        HaveObject.transform.rotation = this.transform.rotation;
    }

    private void Itemaddition(Collider othe)
    {
        //アイテム格納
        var item = othe.gameObject.GetComponent<item>();
        if (item)
        {
            inventory.AddItem(item.itemm, 1);
            Destroy(othe.gameObject);
        }
    }

    private void OpenBox()
    {
        //アイテムボックス
        if (Input.GetKeyDown(KeyCode.E))
        {
           ShowCanvase.OpenItemBox();
        }
    }

    private void OnApplicationQuit()
    {
        //アイテムボックス内リセット
        inventory.container.Clear();
        inventory.Using_Item = null;
        inventory.Merging_Item_First = null;
        inventory.Merging_Item_Second = null;
    }
}
