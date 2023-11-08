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
    private Animator openandclose;
    private GameObject Door;
    private bool open;
    //private bool HitChack;
    bool Chack;
    void Start()
    {
        open = false;
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(Input.GetMouseButtonDown(0));

        if(Input.GetMouseButtonDown(0))
        {
            // オブジェクトを持っていないときはオブジェクトを持つ
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
                    else if(hit.collider.tag == "Door")
                    {
                        Debug.Log("a");
                       openandclose = hit.collider.gameObject.GetComponent<Animator>();
                        Dooropen();
                        openandclose = null;
                    }
                }
            }
            // オブジェクトを持っていないときはオブジェクトを離す
            else
            {
                HaveObject.constraints = 0;
                HaveObject.isKinematic = false;
                HaveObject.transform.SetParent(null, true);
                HaveObject.velocity = parentRigidBody.velocity;
                HaveObject = null;
                open = false;
            }
        }
    }

    private void Dooropen()
    {
        if (open == false)
        {
            StartCoroutine(opening());
        }
        else if (open == true)
        {
            StartCoroutine(closing());
        }
    }
    IEnumerator opening()
    {
        print("you are opening the door");
        openandclose.Play("Opening");
        open = true;
        yield return new WaitForSeconds(.5f);
    }

    IEnumerator closing()
    {
        print("you are closing the door");
        openandclose.Play("Closing");
        open = false;
        yield return new WaitForSeconds(.5f);
    }
}
