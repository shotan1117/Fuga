using SojaExiles;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAcsion : MonoBehaviour
{
    [SerializeField]
    Transform parentObj;

    [SerializeField]
    Rigidbody parentRigidBody;

    private Rigidbody HaveObject;

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(Input.GetMouseButtonDown(0));

        if(Input.GetMouseButtonDown(0))
        {
            // �I�u�W�F�N�g�������Ă��Ȃ��Ƃ��̓I�u�W�F�N�g������
            if(HaveObject == null)
            {

                float distance = 10;
                var hits = Physics.RaycastAll(Camera.main.transform.position, Camera.main.transform.forward, distance);

                foreach(var hit in hits)
                {
                    if (hit.collider.tag == "Object")
                    {
                        HaveObject = hit.collider.gameObject.GetComponent<Rigidbody>();
                        HaveObject.constraints = RigidbodyConstraints.FreezePositionY;
                        HaveObject.transform.position = transform.position + new Vector3(0, 1);
                        HaveObject.isKinematic = true;
                        HaveObject.transform.SetParent(parentObj.transform, true);
                    }
                }
            }
            // �I�u�W�F�N�g�������Ă��Ȃ��Ƃ��̓I�u�W�F�N�g�𗣂�
            else
            {
                HaveObject.constraints = 0;
                HaveObject.isKinematic = false;
                HaveObject.transform.SetParent(null, true);
                HaveObject.velocity = parentRigidBody.velocity;
                HaveObject = null;
            }
        }
    }
}
