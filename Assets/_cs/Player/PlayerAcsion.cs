using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAcsion : MonoBehaviour
{

    private GameObject HaveObject;
    private Rigidbody ObjectRB;
    private bool HitChack;
    bool Chack;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ObjectcarryChack();
        ObjectCarry();
        Debug.Log(Input.GetMouseButtonDown(0));

    }
    public void ObjectcarryChack()
    {       
        if (HitChack && Input.GetMouseButtonDown(0))
        {            
            Chack = true;
            ObjectRB = HaveObject.GetComponent<Rigidbody>();
        }
        if (Chack && Input.GetMouseButtonDown(0))
        {
            ObjectRB = null;
            HaveObject = null;
            Chack = false;
        }
        
    }

    public void ObjectCarry()
    {
        if (HitChack)
        {
            HaveObject.transform.position = this.transform.position;
        }
    }
    private void OnTriggerEnter(Collider Collider)
    {
        if (Collider.gameObject.tag == "Object" && HaveObject == null)
        {
            HaveObject = Collider.gameObject;
            HitChack = true;
        }
    }

    private void OnTriggerExit(Collider Collider)
    {
        if(Collider.gameObject == HaveObject)
        {
           // HaveObject = null;
            ObjectRB = null;
           // HitChack = false;
        }
    }
}
