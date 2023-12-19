using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIdot : MonoBehaviour
{
    public GameObject cv;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if(cv.GetComponent<Canvas>().enabled==false)
        {
            this.gameObject.GetComponent<Canvas>().enabled=true;
        }
        else 
        {
            this.gameObject.GetComponent<Canvas>().enabled = false;
        }
    }
}
