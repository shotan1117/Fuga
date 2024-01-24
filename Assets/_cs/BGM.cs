using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGM : MonoBehaviour
{
    public AudioSource ac;
    // Start is called before the first frame update
    void Start()
    {
        ac = GetComponent<AudioSource>();
        ac.Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
