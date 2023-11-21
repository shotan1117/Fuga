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

    public InventoryObject inventory;

    private void Start()
    {
        BoxCollider.enabled = false;
    }
    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            // オブジェクトを持っていないときはオブジェクトを持つ
            if(HaveObject == null)
            {
                float distance = 10;
                var hits = Physics.RaycastAll(Camera.main.transform.position, Camera.main.transform.forward, distance);
                Debug.Log(hits);
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
        ObjectCollider = othe;
        HaveObject = ObjectCollider.gameObject.GetComponent<Rigidbody>();
        ObjectCollider.enabled = false;  
        BoxCollider.enabled = true;
        HaveObject.constraints = RigidbodyConstraints.FreezePositionY;
        HaveObject.isKinematic = true;
        HaveObject.transform.SetParent(parentObj.transform, true);
        HaveObject.transform.localPosition = new Vector3(0, 0.1f, 0.3f);
        ObjectCollider.transform.rotation = transform.rotation;
    }

    private void Itemaddition(Collider othe)
    {
        var item = othe.GetComponent<item>();
        if (item)
        {
            inventory.AddItem(item.itemm, 1);
            Destroy(othe.gameObject);
        }
    }
}
