using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TitleCamera : MonoBehaviour
{

    //’†S“_
    [SerializeField]
    private Vector3 center = Vector3.zero;
    //‰ñ“]²
    [SerializeField]
    private Vector3 axis = Vector3.up;
    //‰~‰^“®“¯Šú
    [SerializeField] private float period;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //’†S“_‚Ìü‚è‚ğ²axis‚Åperiod“¯Šú‚Å‰~‰^“®
        transform.RotateAround(center, axis, 360 / period * Time.deltaTime);
    }
}
