using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_control : MonoBehaviour
{
    Camera MyCamera;
    // Start is called before the first frame update
    void Start()
    {
        MyCamera = GetComponent<Camera>();
        MyCamera.enabled = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            Debug.Log("a");
            MyCamera.enabled = true; 
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            MyCamera.enabled = false;
        }
    }
}
