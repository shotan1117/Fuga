using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGM : MonoBehaviour
{
    public AudioSource as1;
    public AudioClip ac1;
    public AudioClip ac2;
    int end;

    // Start is called before the first frame update
    void Start()
    {
        as1 = GetComponent<AudioSource>();
        end = PlayerPrefs.GetInt("flag");
        if (end == 1)
        {
            as1.PlayOneShot(ac1);
        }
        else
        {
            as1.PlayOneShot(ac2);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
