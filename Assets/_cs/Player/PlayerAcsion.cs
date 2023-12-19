using NavKeypad;
using SojaExiles;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
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

    [SerializeField]
    AudioClip clip;

    //�L���b�`�����I�u�W�F�N�g�̎擾
    private Rigidbody HaveObject;
    private Collider ObjectCollider;

    public AudioSource audioSource;

    //�A�C�e���{�b�N�X
    public ShowCanvas ShowCanvase;
    public InventoryObject inventory;

    private Gimmick gimmick;
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
            // �I�u�W�F�N�g�������Ă��Ȃ��Ƃ��̓I�u�W�F�N�g������
            if(HaveObject == null)
            {
                float distance = 15;
                RaycastHit hit;
                if( Physics.Raycast(Camera.main.transform.position, Camera.main.transform.forward, out hit, distance)) 
                {
                    switch(hit.collider.tag)
                    {
                        case "Object":
                            ObjectCatch(hit.collider);
                            break;

                        case "Item":
                            Itemaddition(hit.collider);
                            break;

                        case "Gimmick":
                            ShowCanvase.OpenItemBox();
                            gimmick = hit.collider.GetComponent<Gimmick>();
                            break;
                    }
                }
            }
            // �I�u�W�F�N�g�������Ă��Ȃ��Ƃ��̓I�u�W�F�N�g�𗣂�
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
                gimmick = null;
            }
        }
      
    }

    private void ObjectCatch(Collider othe)
    {
        //���Ă�I�u�W�F�N�g�擾
        ObjectCollider = othe;
        HaveObject = ObjectCollider.gameObject.GetComponent<Rigidbody>();
        ObjectCollider.enabled = false;  
        BoxCollider.enabled = true;
        HaveObject.constraints = RigidbodyConstraints.FreezePositionY;
        HaveObject.isKinematic = true;
        HaveObject.transform.SetParent(parentObj.transform, true);
        HaveObject.transform.localPosition = new Vector3(0, 0.1f, 0.41f); 
        HaveObject.transform.rotation = this.transform.rotation;
    }

    private void Itemaddition(Collider other)
    {
        //�A�C�e���i�[
        var item = other.gameObject.GetComponent<itemData>();
        if (item)
        {
            inventory.AddItem(item.i, 1);
            audioSource.PlayOneShot(clip);
            Destroy(other.gameObject);
        }
    }

    private void OpenBox()
    {
        //�A�C�e���{�b�N�X
        if (Input.GetButtonDown("Inventory"))
        {
           ShowCanvase.OpenItemBox();
        }
    }

    private void OnApplicationQuit()
    {
        //�A�C�e���{�b�N�X�����Z�b�g
        inventory.container.Clear();
        inventory.Using_Item = null;
        inventory.Merging_Item_First = null;
        inventory.Merging_Item_Second = null;
    }

    public void UseItem(int itemID)
    {
        //�A�C�e���g�p
        if (gimmick != null)
        {
            gimmick.UseObject(itemID);
            ShowCanvase.OpenItemBox();
        }
    }
}
