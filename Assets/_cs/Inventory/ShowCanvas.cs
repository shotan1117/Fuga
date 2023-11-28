using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowCanvas : MonoBehaviour
{
    Canvas cv;
    // Start is called before the first frame update
    void Start()
    {
        cv= GetComponent<Canvas>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.E)&&
            cv.enabled==true)
        {
            cv.enabled = false;
        }
        else if (Input.GetKeyDown(KeyCode.E)
            &&cv.enabled==false)
        {
            cv.enabled=true;
        }
        
    }
}
