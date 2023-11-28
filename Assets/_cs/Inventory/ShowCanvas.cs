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
        cv.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OpenItemBox()
    {       
        if ( cv.enabled == true)
        {
            Time.timeScale = 1;
            cv.enabled = false;
            Cursor.visible = false;
            Cursor.lockState = CursorLockMode.Locked;
        }
        else if ( cv.enabled == false)
        {
            Time.timeScale = 0;
            cv.enabled = true;
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.Confined;
        }
    }
}
